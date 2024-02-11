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


 
}