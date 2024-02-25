using System.ComponentModel;

namespace JohnBPearson.KeyBindingButler.Model
{
    public interface IBase
    {
        KeyBinding Key { get; }
        char KeyAsChar { get; }
        string Description { get; set; }
    }
    public interface IKeyBoundData : IEquatable<IKeyBoundData>, IBase
    {



        ContentsForClipboard Data { get; }


        void Update(string newValue);
        string GetDelimitated();


    }


    public interface IKeyBoundCommand: IBase // , IEquatable<IKeyBoundCommand>
    {

    }
}

//    public abstract class KeyBoundDataBase
//    {



//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        /// <param name="item">the item to be replaced</param>
//        ///// <returns></returns>
//        //public static IKeyBoundData CreateForReplace(string key, string value, KeyBoundData item)
//        //{
//        //    return KeyBoundData.KeyBoundDataBase Create(string key, string value)
//        //}
//    }
//}