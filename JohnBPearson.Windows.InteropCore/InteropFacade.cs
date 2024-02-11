using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.Windows.Interop
{

    public delegate void KeyBindCallBack(string data);
    public class InteropFacade
    {
        public InteropFacade() { }



        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    }
}
