using System;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace JohnBPearson.KeyBindingButler.Model
{


    public class KeyBoundData : IKeyBoundData
    {
        private Data _data;
        private bool _lastInList;
        private KeyboardKey _key;
        public KeyboardKey Key
        {
            get { return _key; }
            private set { _key = value; }
        }
        public Data Data
        {
            get { return _data; }
            private set
            {
                if (value != this._data)
                {
                    this._data = value;
                 
                }
            }
        }
        private Description _description;
        public Description Description
        {
            get { return _description ; }
             set
            {
                if (value != this._description)
                {
                    this._description = value;

                }
            }
        }



        public char KeyAsChar
        {
            get
            {

                if (!string.IsNullOrWhiteSpace(_key.Value))
                {

                    return _key.Value.ToCharArray()[0];
                }

                return ' ';
            }

        }
        //private string _description = "";
        //public string Description
        //{
        //    get { return _description; } private set { if (value != this._description && !string.IsNullOrWhiteSpace(value) ){
        //            _description = value;
        //        } }
        //}

        private ObjectState _ojectState;
        public ObjectState ObjectStat
        {
            get { return this._ojectState; }
        }

        public ObjectState ObjectState => throw new NotImplementedException();

        protected KeyBoundData()
        {
        }
        protected KeyBoundData(char key, string value)
        {
            Key = KeyboardKey.Create(key);
            Data = Data.Create(value);
        }


        protected KeyBoundData(char key, string value, string description)
        {
            Key = KeyboardKey.Create(key);
            Data = Data.Create(value);
            Description = Description.Create(description);
            
        }


        private void setIfLastItem(KeyboardKey key)
        {
            /// z is the last in the keyboard key list 
            if(key.Key == 'z')
            {
                this._lastInList = true;
            }
        }


        internal static KeyBoundData Create(char key, string value, string description = "")
        {
            return new KeyBoundData(key, value, description);
        }

        internal static KeyBoundData CreateForReplace(Data newValue, IKeyBoundData oldItem)
        {
            if (!newValue.Equals(oldItem.Data))
            {
                return new KeyBoundData(oldItem.Key.Key, newValue.Value);
            }
            if (oldItem is KeyBoundData)
            {
                return (KeyBoundData)(oldItem);
            } else
            {
                throw new NotImplementedException();
            }
        }

        public bool Equals(KeyBoundData other)
        {
            if (this.Data == other.Data && this.KeyAsChar == other.KeyAsChar)
            {
                return true;
            }
            return false;
        }

      
          
        
        public  string GetDelimitated()
        {
            return string.Concat(this._key.GetDeliminated(), this._data.ToString());
                    
        }

        public void Update(string newValue)
        {
            if(this.Data.Value != newValue)
           this.Data.Value= newValue;
        }

        public bool Equals(IKeyBoundData other)
        {
            if (other.Data.Equals(this.Data))
            {
                return true;
            }
            return false;
        }
    }
}