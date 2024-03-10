using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JohnBPearson.com.Utility;

namespace JohnBPearson.KeyBindingButler.Model
{

    public class KeyBindingButler : ButlerBase
    {

        private Parser _userSettingsHelper;
        private List<IKeyBoundData> _items = new List<IKeyBoundData>();

        public KeyBindingButler(KeyAndDataStringLiterals strings, string hisName) : base(hisName)
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

        public void Update(IKeyBoundData newItem, IKeyBoundData oldItem)
        {

            if(newItem.Equals(oldItem))
            {

                oldItem.Update(newItem.Data.Value);
            }
          //  var newKeyBoundValue = KeyBoundData.CreateForReplace(newItem.Data, oldItem);
            var index = this._items.IndexOf(oldItem);
            this._items.RemoveAt(index);
            this._items[index] = newItem;
            //  return this._items;
        }

        public KeyAndDataStringLiterals PrepareDataForSave()
        {
            var sbKeys = new StringBuilder();
            var sbData = new StringBuilder();
            int count = 0;
            foreach (var item in _items)
            {
             //   if (item.IsDirty) count++;

                sbKeys.Append(item.Key.ToString());
                sbData.Append(item.Data.ToString());
            }
            var result = new KeyAndDataStringLiterals();
            result.Values = sbData.ToString();
            result.Keys = sbKeys.ToString();
            result.ItemsUpdated = count;
            return result;
        }
    }
}

