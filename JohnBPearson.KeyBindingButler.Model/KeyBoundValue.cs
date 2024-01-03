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


    public class KeyBoundValue : IKeyBoundValue, IEquatable<KeyBoundValue>
    {
        private ContentsForClipboard _value;

        private KeyBinding _key;
        public KeyBinding Key
        {
            get { return _key; }
            private set { _key = value; }
        }
        public ContentsForClipboard Value
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


        protected KeyBoundValue()
        {
        }
        protected KeyBoundValue(char key, string value)
        {
            Key = KeyBinding.Create(key);
            Value = ContentsForClipboard.Create(value);
        }

        protected KeyBoundValue(char key, string value, bool isDirty)
        {
            this._key = KeyBinding.Create(key);
            this._value = ContentsForClipboard.Create(value);
            this._isDirty = isDirty;
        }


        internal static KeyBoundValue Create(char key, string value)
        {
            return new KeyBoundValue(key, value);
        }

        internal static KeyBoundValue CreateForReplace(ContentsForClipboard newValue, IKeyBoundValue oldItem)
        {
            if (!newValue.Equals(oldItem.Value))
            {
                return new KeyBoundValue(oldItem.Key.Key, newValue.Value, true);
            }
            return new KeyBoundValue(oldItem.Key.Key, oldItem.Value.Value, oldItem.IsDirty);
        }

        public bool Equals(KeyBoundValue other)
        {
            if (this.Value == other.Value && this.KeyAsChar == other.KeyAsChar)
            {
                return true;
            }
            return false;
        }

        public IKeyBoundValue Recreate(string newValue)
        {
            return KeyBoundValue.Create(this.KeyAsChar, newValue);
        }


    }

    public struct KeyAndValuesStringLiterals
    {
        public string Keys;
        public string Values;
        public int ItemsUpdated;


    }
}
  