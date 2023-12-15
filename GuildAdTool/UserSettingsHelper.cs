using System.Collections.Generic;
using System.Linq;
using System.Text;
using JohnBPearson.KeyBindingButler.Model;

namespace JohnBPearson.Windows.Forms.KeyBindingButler
{
    public class UserSettingsHelper
    {

        private List<KeyBoundValue> _items;

        public List<KeyBoundValue> Items
        {
            get {
                if(this._items == null)
                {
                   this.setParsed();
                }
                return this._items;
                }
           private  set { this._items = value; }
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

        private List<KeyBoundValue> parse()
        {
            var letters = Properties.Settings.Default.AllowedHotkeys.Split(delim).Clone();
            var values = Properties.Settings.Default.HotkeyValues.Split(delim);
            this._keys =(letters as string[]).ToList();
         
            var resultList = new List<KeyBoundValue>();
            var index = 0;
            foreach (var key in letters as string[])
            {
                var value = values[index];
                var hkv = new KeyBoundValue(key, value);
                resultList.Add(hkv);
                index++;
            }
         
            return resultList;
        }
        private const char delim = '|';
        private void updateItems()
        {
            var keys = new StringBuilder();
            var values = new StringBuilder();
            foreach (var item in this.Items) {
                keys.Append(string.Format(item.Key, delim));
                values.Append(string.Format(item.Value, delim));
            }
            Properties.Settings.Default.HotkeyValues = Items.ToString();
            Properties.Settings.Default.Save();
        }
    
    
    }




}
