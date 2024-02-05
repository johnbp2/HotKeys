using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using JohnBPearson.KeyBindingButler.Model;

namespace JohnBPearson.com.Utility
{
    internal class Parser

    {

        public Parser(KeyAndValuesStringLiterals strings)
        {

            this._valuesString = strings.Values;

            this._keysString = strings.Keys;

        }

        private string _keysString;
        private string _valuesString;

        private List<JohnBPearson.KeyBindingButler.Model.IKeyBoundValue> _items;

        public List<JohnBPearson.KeyBindingButler.Model.IKeyBoundValue> Items
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

        private List<JohnBPearson.KeyBindingButler.Model.IKeyBoundValue> parse()
        {
            string[] delims = { delim };
            var resultList = new List<IKeyBoundValue>();
            //   var letters = this._keysString.Split(delims, 100, StringSplitOptions.None).Clone();
            var letters = this._keysString.Split(delimChar).Clone();
            var values = this._valuesString.Split(delimChar);
            this._keys = (letters as string[]).ToList();
            var index = 0;
            foreach (var key in this._keys)
            {
                if (index < values.Length)
                {
                    var value = values[index];
                    var hkv = JohnBPearson.KeyBindingButler.Model.KeyBoundValue.Create(key[0], value);
                    resultList.Add(hkv);
                    index++;
                }
                else
                {
                    break;
                }

            }
            checkAndRepairValuesArray(values);

            return resultList;
        }

        private string[] checkAndRepairValuesArray(string[] values)
        {
            if (values.Length < 26)
            {
             var needToAdd = 26- values.Length;
                
                for (int i = 0; i < needToAdd; i++)
                {
                    values.Append("");
                }
            }
            return values;
        }

        private const string delim = "|";
        private const char delimChar = '|';
        internal KeyAndValuesStringLiterals updateStrings(List<JohnBPearson.KeyBindingButler.Model.IKeyBoundValue> items)
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
                tempValues.Add(item.Value.ToString());
            }
            var strings = new KeyAndValuesStringLiterals();
          
            strings.Keys = tempKeys.ToString();
            strings.Values = this.checkAndRepairValuesArray(tempValues.ToArray()).ToString();
            return strings;
        }


    }
}


