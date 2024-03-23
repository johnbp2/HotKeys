using System;

namespace JohnBPearson.KeyBindingButler.Model
{
    public interface IBaseData :IEquatable<IBaseData>
    {
        string Value { get; set; }

       // bool Equals(IBaseData other);    
        string GetDeliminated();
        string GetDeliminated(char delim);
        string GetDelimiter();
        string ToString();
    }
}