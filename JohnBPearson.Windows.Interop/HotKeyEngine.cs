using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using JohnBPearson.KeyBindingButler.Model;
using JohnBPearson.Windows.Interop;

public class BoundKeyActionEventArgs : EventArgs
{
    public string Key { get; set; }
    public string Value { get; set;}
    public BoundKeyActionEventArgs() { 

            
            }
}



public class GlobalHotKey : IDisposable
 {
  
 
  // internal static InteropFacade facade = new InteropFacade();
        /// <summary>
        /// Registers a global hotkey
        /// </summary>
        /// <param name="aKeyGesture">e.g. Alt + Shift + Control + Win + s</param>
        /// <param name="aAction">Action to be called when hotkey is pressed</param>
        /// <returns>true, if registration succeeded, otherwise false</returns>
        public static bool RegisterHotKey(string aKeyGestureString, Action aAction, string data)
        {
     
            var c = new KeyGestureConverter();
            KeyGesture keyGesture = (KeyGesture)c.ConvertFrom(aKeyGestureString);
            return RegisterHotKey(keyGesture.Modifiers, keyGesture.Key, data, aAction);
        }
    public static bool RegisterHotKey(string aKeyGestureString, string data, KeyBindCallBack callBack)
    {

        var c = new KeyGestureConverter();
        KeyGesture aKeyGesture = (KeyGesture)c.ConvertFrom(aKeyGestureString);
       return RegisterHotKey(aKeyGesture.Modifiers, aKeyGesture.Key, data, null , callBack);
    }
    private static bool RegisterHotKey(ModifierKeys modifier, Key key, string data, Action action =  null, KeyBindCallBack callBack = null)
        {
        if (modifier == ModifierKeys.None)
        {
            throw new ArgumentException("Modifier must not be ModifierKeys.None");
        }
        if (callBack is null)
        {
           
            if (action is null)
            {
                throw new ArgumentException("Action or delegate must be provided.");
            }

            System.Windows.Forms.Keys aVirtualKeyCode = (System.Windows.Forms.Keys)KeyInterop.VirtualKeyFromKey(key);
            currentID = currentID + 1;
            bool aRegistered = InteropFacade.RegisterHotKey(window.Handle, currentID,
                                        (uint)modifier | MOD_NOREPEAT,
                                        (uint)aVirtualKeyCode);

            if (aRegistered && action != null)
            {
                registeredHotKeys.Add(new HotKeyWithAction(modifier, key,data, action: action, callBack: null));
            }
            return aRegistered;
       } else  {

            if (callBack is null)
            {
                throw new ArgumentNullException(nameof(callBack));
            }

            System.Windows.Forms.Keys aVirtualKeyCode = (System.Windows.Forms.Keys)KeyInterop.VirtualKeyFromKey(key);
            currentID = currentID + 1;
            bool aRegistered = InteropFacade.RegisterHotKey(window.Handle, currentID,
                                        (uint)modifier | MOD_NOREPEAT,
                                        (uint)aVirtualKeyCode);

            if (aRegistered)
            {
                registeredHotKeys.Add(new HotKeyWithAction(modifier, key, data ,action: action, callBack: callBack));
            }
            return aRegistered;
        }
    }

        public void Dispose()
        {
            // unregister all the registered hot keys.
            for (int i = currentID; i > 0; i--)
            {
            InteropFacade.UnregisterHotKey(window.Handle, i);
            }

            // dispose the inner native window.
            window.Dispose();
        }

        static GlobalHotKey()
        {
        //BoundKeyAction = new EventHandler<BoundKeyActionEventArgs>()
            window.KeyPressed += (s, e) =>
            {
                registeredHotKeys.ForEach(x =>
                {
                    if (e.Modifier == x.Modifier && e.Key == x.Key)
                    {
                        if (x.Action != null)
                        {
                            x.Action();

                        }
                        else if (x.CallBack != null)
                        {
                            x.CallBack.Invoke(x.Key.ToString(),x.Data);
                        }
                       
                    }
                });
            };
        }

        private static readonly InvisibleWindowForMessages window = new InvisibleWindowForMessages();
        private static int currentID;
        private static uint MOD_NOREPEAT = 0x4000;
        private static List<HotKeyWithAction> registeredHotKeys = new List<HotKeyWithAction>();
    /// <summary>
    /// Action parameter is deprecated
    /// </summary>
    private class HotKeyWithAction    {

        public HotKeyWithAction(ModifierKeys modifier, Key key, string data, Action action = null, KeyBindCallBack callBack = null)
        {
            Modifier = modifier;
            Key = key;
            if (action != null)
            {
                Action = action;
            }
            if(callBack != null)
            {
                CallBack = callBack;
            }
            Data = data;
        }

        public ModifierKeys Modifier { get; }
        public Key Key { get; }
        public string Data { get;  } 
        public Action Action { get; }
        public KeyBindCallBack CallBack { get; }

    }      

        private class InvisibleWindowForMessages : System.Windows.Forms.NativeWindow, IDisposable
        {
            public InvisibleWindowForMessages()
            {
                CreateHandle(new System.Windows.Forms.CreateParams());
            }

            private static int WM_HOTKEY = 0x0312;
            protected override void WndProc(ref System.Windows.Forms.Message m)
            {
                base.WndProc(ref m);

                if (m.Msg == WM_HOTKEY)
                {
                    var aWPFKey = KeyInterop.KeyFromVirtualKey(((int)m.LParam >> 16) & 0xFFFF);
                    ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);
                    if (KeyPressed != null)
                    {
                        KeyPressed(this, new HotKeyPressedEventArgs(modifier, aWPFKey));
                    }
                }
            }

            public class HotKeyPressedEventArgs : EventArgs
            {
                private ModifierKeys _modifier;
                private Key _key;

                internal HotKeyPressedEventArgs(ModifierKeys modifier, Key key)
                {
                    _modifier = modifier;
                    _key = key;
                }

                public ModifierKeys Modifier
                {
                    get { return _modifier; }
                }

                public Key Key
                {
                    get { return _key; }
                }
            }


            public event EventHandler<HotKeyPressedEventArgs> KeyPressed;

            #region IDisposable Members

            public void Dispose()
            {
                this.DestroyHandle();
            }

            #endregion
        }
    } 


