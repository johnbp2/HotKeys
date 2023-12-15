//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Navigation;
//using JohnBPearson.Json.DataAccess;

//namespace JohnBPearson.Windows.Forms.KeyBindingButler.Models
//{
//    public class KeyBoundValue 
//    {
//        public string Key
//        {
//            get; set;
//        }
//        public string Value
//        {
//            get; set;
//        }
//        public KeyBoundValue()
//        {
//        }
//        public KeyBoundValue(string key, string value)
//        {
//            Key = key;
//            Value = value;
//        }
//    }

//    public class Wrapper : IListWrapper<KeyBoundValue>
//    {
//        private List<KeyBoundValue> _items;
//        public Wrapper() { }
//        public List<KeyBoundValue> Items { get => _items; set => _items = value   ; }
//    }
//}
