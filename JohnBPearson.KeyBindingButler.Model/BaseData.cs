using System;
using System.Collections.Generic;
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
        private string _value;
        public virtual string Value { get => this._value; set => this._value = value; }

        public string deliminater = ",";

        public override string ToString() {
            return Value;
        }
        public string GetDeliminated()
        {
            return string.Concat(Value, deliminater);
        }
        public bool Equals(BaseData other)
        {
            if((this._value !=null ? this._value : "") == (other != null ? other.Value != null ? other.Value: "" : ""))
            {
                return true;
            }
            return false;
        }
    }
}
