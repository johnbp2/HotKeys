using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.NET.Extensions
{


    //public class CardType
    //: Enumeration
    //{
    //    public static CardType Amex = new(1, nameof(Amex));
    //    public static CardType Visa = new(2, nameof(Visa));
    //    public static CardType MasterCard = new(3, nameof(MasterCard));

    //    public CardType(int id, string name)
    //        : base(id, name)
    //    {
    //    }
    //}
    //public abstract class Enumeration : IComparable
    //{
    //    public string Name
    //    {
    //        get; private set;
    //    }

    //    public int Id
    //    {
    //        get; private set;
    //    }

    //    protected Enumeration(int id, string name) => (Id, Name) = (id, name);

    //    public override string ToString() => Name;

    //    public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
    //        typeof(T).GetFields(BindingFlags.Public |
    //                            BindingFlags.Static |
    //                            BindingFlags.DeclaredOnly)
    //                 .Select(f => f.GetValue(null))
    //                 .Cast<T>();

    //    public override bool Equals(object obj)
    //    {
    //        if (!(obj is  Enumeration otherValue))
    //        {
    //            return false;
    //        }

    //        var typeMatches = GetType().Equals(obj.GetType());
    //        var valueMatches = Id.Equals(otherValue.Id);

    //        return typeMatches && valueMatches;
    //    }

    //    public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);

    //    // Other utility methods ...
    //}
}
