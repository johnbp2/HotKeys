using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.Json.DataAccess
{
    public interface IDataAccess<T> where T : ICollectionItem
    {
        List<T> GetCollection(string collectionName);
        void SetCollection(List<T> collection, string collectionName);

    }

    public interface ICollectionItem
    {
        string Key { get; set; }
    }

    public interface IHotkeyValueItem
    {
        string Key { get; set; }
        string Value { get; set; }
    }

    public interface IListWrapper<T>
    {

         List<T> Items { get; set; }
    }



    //public interface IHotkeyValueItems
    //{
    //    List<HotkeyValueItem> Items { get; set; }
    //}
}
