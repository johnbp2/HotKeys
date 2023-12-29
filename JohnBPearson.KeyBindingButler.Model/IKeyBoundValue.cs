using System.ComponentModel;

namespace JohnBPearson.KeyBindingButler.Model
{
    public interface IKeyBoundValue
    {
        bool IsDirty { get; }
        KeyBinding Key { get; }
        char KeyAsChar { get; }
        ContentsForClipboard Value { get; }
        IKeyBoundValue Recreate(string newValue);
      

    }


    public abstract class KeyBoundValueBase
    {



        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="item">the item to be replaced</param>
        ///// <returns></returns>
        //public static IKeyBoundValue CreateForReplace(string key, string value, KeyBoundValue item)
        //{
        //    return KeyBoundValue.KeyBoundValueBase Create(string key, string value)
        //}
    }
}