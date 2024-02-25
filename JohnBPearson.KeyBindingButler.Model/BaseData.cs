using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.KeyBindingButler.Model
{


 
    public abstract class BaseData : IEquatable<BaseData>
    {
        protected BaseData() { }
        protected BaseData(string value)
        {
            if (value == null) value = string.Empty;
            this._value = value;
        }
        private string _value = "";
        public virtual string Value { get { return _value; } set {if(!string.IsNullOrWhiteSpace(value))
                {
                    this._value = value;
                }
                    } }

        public readonly string deliminater = "|";

        public override string ToString() {
            return Value;
        }
        public string GetDeliminated()
        {
            return string.Concat(Value, deliminater);
        }

        public string GetDeliminated(char delim)
        {
            switch (delim)
            {
                case ',':

                    break;
                case '?':

                    break;
                case '!':

                    break;
                case '/':

                    break;
                case '\\':

                    break;
                case '#':

                    break;
                case '%':

                    break;
                default:
                   throw new ArgumentException($"{nameof(delim)} is invalid for deliminater. Allowed chars are , ? ! / \\ # %");
                    break;
            }
            return string.Concat(Value, delim.ToString());
        }
        public bool Equals(BaseData other)
        {
            if(other != null && !string.IsNullOrWhiteSpace(other.Value))
            {
                
                return this._value == other.Value;
            }
            return false;
        }
    }
}
