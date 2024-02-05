using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JohnBPearson.KeyBindingButler.Model;

namespace JohnBPearson.com.Utility
{
    internal class Parser

    {

        public Parser(KeyAndDataStringLiterals strings)
        {

            this._valuesString = strings.Values;

            this._keysString = strings.Keys;

        }

        private string _keysString;
        private string _valuesString;

        private List<JohnBPearson.KeyBindingButler.Model.IKeyBoundData> _items;

        public List<JohnBPearson.KeyBindingButler.Model.IKeyBoundData> Items
        {
            get
            {
                if (this._items == null)
                {
                    this.setParsed();
                }
                return this._items;
            }
            private set { this._items = value; }
        }

        private List<string> _keys;

        public List<string> Keys
        {
            get
            {
                if (this._keys == null)
                {
                    this.setParsed();
                }
                return this._keys;
            }
            private set { _keys = value; }
        }

        private void setParsed()
        {
            this._items = this.parse();

        }

        private List<JohnBPearson.KeyBindingButler.Model.IKeyBoundData> parse()
        {
            string[] delims = { delim };
            var resultList = new List<IKeyBoundData>();
            //   var letters = this._keysString.Split(delims, 100, StringSplitOptions.None).Clone();
            char[] chars = { delimChar };
            var letters = this._keysString.Split(chars, StringSplitOptions.RemoveEmptyEntries).Clone();
             var values = this._valuesString.Split(chars, StringSplitOptions.RemoveEmptyEntries).Clone();
            this._keys = (letters as string[]).ToList();
            var index = 0;
            var valuesTyped = values as string[];
            foreach (var key in this._keys)
            {
                if (index < 26)
                {
                    var value = valuesTyped[index];
                    var hkv = JohnBPearson.KeyBindingButler.Model.KeyBoundData.Create(key[0], value);
                    resultList.Add(hkv);
                    index++;
                }
                else
                {
                    break;
                }

            }

            return resultList;
        }
        private const string delim = "|";
        private const char delimChar = '|';
        internal KeyAndDataStringLiterals updateStrings(List<JohnBPearson.KeyBindingButler.Model.IKeyBoundData> items)
        {
            var result = 0;
            var tempKeys = new List<string>();
            var tempValues = new List<string>();

            var values = new StringBuilder();
            foreach (var item in this.Items)
            {
                if (item.IsDirty)
                {
                    result++;

                }
                tempKeys.Add(item.Key.ToString());
                tempValues.Add(item.Data.ToString());
            }
            var strings = new KeyAndDataStringLiterals();
            strings.Keys = tempKeys.ToString();
            strings.Values = tempValues.ToString();
            return strings;
        }


    }


}


