using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.KeyBindingButler.Model
{


    public class KeyBoundValue
    {
        private string _value = string.Empty;

        private string _key = string.Empty;
        public string Key
        {
            get { return _key; }
            private set { _key = value; }
        }
        public string Value
        {
            get { return _value; }
            private set { _value = value; }
        }
        public KeyBoundValue()
        {
        }
        public KeyBoundValue(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public char KeyAsChar
        {
            get
            {

                if (!string.IsNullOrWhiteSpace(_key))
                {

                  return   _key.ToCharArray()[0];
                }

                return ' ';
            }

        }
    }
}



