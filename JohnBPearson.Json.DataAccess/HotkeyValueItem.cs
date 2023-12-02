using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.Json.DataAccess
{
 

    public class HotkeyValueItem : IHotkeyValueItem
    {    internal interface IHotkeyValueItem
    {
        string Key { get; set; }
        string Value { get; set; }
    }
        public string Key
        {
            get; set;
        }
        public string Value
        {
            get; set;
        }
        internal HotkeyValueItem()
        {
        }
        internal HotkeyValueItem(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }


    public class HotkeyValueItems : IHotkeyValueItems
    {
        public List<HotkeyValueItem> Items { get; set; }

        internal HotkeyValueItems()
        { }
    }


}

