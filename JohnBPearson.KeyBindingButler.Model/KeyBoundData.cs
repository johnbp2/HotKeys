using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using JohnBPearson.com.Utility;

namespace JohnBPearson.KeyBindingButler.Model
{


    public class KeyBoundData : IKeyBoundData, IEquatable<KeyBoundData>
    {
        private ContentsForClipboard _value;

        private KeyBinding _key;
        public KeyBinding Key
        {
            get { return _key; }
            private set { _key = value; }
        }
        public ContentsForClipboard Data
        {
            get { return _value; }
            private set
            {
                if (value != this._value)
                {
                    this._value = value;
                    this._isDirty = true;
                }
            }
        }

        private bool _isDirty = false;
        public bool IsDirty
        {
            get
            {
                return this._isDirty;
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


        protected KeyBoundData()
        {
        }
        protected KeyBoundData(char key, string value)
        {
            Key = KeyBinding.Create(key);
            Data = ContentsForClipboard.Create(value);
        }

        protected KeyBoundData(char key, string value, bool isDirty)
        {
            this._key = KeyBinding.Create(key);
            this._value = ContentsForClipboard.Create(value);
            this._isDirty = isDirty;
        }


        internal static KeyBoundData Create(char key, string value)
        {
            return new KeyBoundData(key, value);
        }

        internal static KeyBoundData CreateForReplace(ContentsForClipboard newValue, IKeyBoundData oldItem)
        {
            if (!newValue.Equals(oldItem.Data))
            {
                return new KeyBoundData(oldItem.Key.Key, newValue.Value, true);
            }
            return new KeyBoundData(oldItem.Key.Key, oldItem.Data.Value, oldItem.IsDirty) ;
        }

        public bool Equals(KeyBoundData other)
        {
            if (this.Data == other.Data && this.KeyAsChar == other.KeyAsChar)
            {
                return true;
            }
            return false;
        }

        public IKeyBoundData Recreate(string newValue)
        {
            return KeyBoundData.Create(this.KeyAsChar, newValue);
        }
          
        
        public  string GetDeliminated()
        {
            return string.Concat(this._key.GetDeliminated(), this._value.ToString());
                    
        }
            
     }

    public struct KeyAndDataStringLiterals
    {
        public string Keys;
        public string Values;
        public int ItemsUpdated;

      
    }
    public class KeyBoundDataList
    {

        private Parser _userSettingsHelper;
        private List<IKeyBoundData> _items = new List<IKeyBoundData>();
        private const string deliminater = "|";

        public KeyBoundDataList(KeyAndDataStringLiterals strings)
        {
            this._userSettingsHelper = new Parser(strings);
            this._items = this._userSettingsHelper.Items;

        }

        public IEnumerable<string> Keys
        {
            get
            {
                if (this._userSettingsHelper != null)
                {
                    return this._userSettingsHelper.Keys;
                }
                else return null;
            }
        }
        public IEnumerable<IKeyBoundData> Items
        { get { return this._items; } }

        public void Replace(IKeyBoundData newItem, IKeyBoundData oldItem)
        {


            var newKeyBoundValue = KeyBoundData.CreateForReplace(newItem.Data, oldItem);
            var index = this._items.IndexOf(oldItem);
            this._items.RemoveAt(index);
            this._items[index] = newItem;
            //  return this._items;
        }

        public KeyAndDataStringLiterals PrepareDataForSave() {
            var sbKeys = new StringBuilder();
           
            var sbValues = new StringBuilder();
            int count = 0;
            foreach (var item in _items)
            {if (item.IsDirty) count++;                        
                        
                sbKeys.Append(item.Key.ToString();
                sbValues.Append(item.Data.ToString());
            }
            var result = new KeyAndDataStringLiterals();
            result.Values = sbValues.ToString();
            result.Keys = sbKeys.ToString();
            result.ItemsUpdated = count;
           return result;
        }

        public string PrepareDataToSaveAsOneSetting()
        {
            var sbOneString = new StringBuilder();
            foreach (var item in _items)
            {
                sbOneString.Append(this.buildSaveString(item));

                    
            }
           return sbOneString.ToString();
        }

        private string buildSaveString(IKeyBoundData item)
        {
            return String.Concat(item.Key.GetDeliminated(),item.Data, KeyBoundDataList.deliminater);
        }
    }
}