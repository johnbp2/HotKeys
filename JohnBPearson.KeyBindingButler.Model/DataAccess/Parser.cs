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

        public Parser(KeyAndDataStringLiterals strings)
        {

            this._valuesString = strings.Values;

            this._keysString = strings.Keys;
            this._descriptionString = strings.Descriptions;

        }

        private string _keysString;
        private string _valuesString;
        private string _descriptionString;

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
            var letters = this._keysString.Split(delimChar).Clone();
            var values = this._valuesString.Split(delimChar);
            var descriptions = this._descriptionString.Split(delimChar);
            this._keys = (letters as string[]).ToList();
            var index = 0;
            foreach (var key in this._keys)
            {
                if (index < values.Length)
                {
                    var value = values[index];
                    var des = descriptions[index];
                    var hkv = JohnBPearson.KeyBindingButler.Model.KeyBoundData.Create(key[0], value, des);
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
        internal KeyAndDataStringLiterals updateStrings(List<JohnBPearson.KeyBindingButler.Model.IKeyBoundData> items)
        {
            var result = 0;
            var tempKeys = new List<string>();
            var tempValues = new List<string>();

            var values = new StringBuilder();
            foreach (var item in this.Items)
            {
               
                tempKeys.Add(item.Key.GetDeliminated());
                tempValues.Add(item.Data.GetDeliminated());
            }
            var strings = new KeyAndDataStringLiterals();
          
            strings.Keys = tempKeys.ToString();
            strings.Values = this.checkAndRepairValuesArray(tempValues.ToArray()).ToString();
            return strings;
        }


    }
}


