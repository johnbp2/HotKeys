

using System.Dynamic;
using System.Net.Http.Headers;

namespace JohnBPearson.KeyBindingButler.Model
{

    public enum ObjectState
    {
        New,
        Mutated,
        Deleted,

    }
    public interface IBase
    {
        KeyboardKey Key { get; }
        Data Data { get; }
        char KeyAsChar { get; }
        
        ObjectState ObjectState { get; }
    }
    public interface IKeyBoundData : System.IEquatable<IKeyBoundData>, IBase
    {



        Description Description { get; set; }


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