using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace JohnBPearson.KeyBindingButler.Model
{
    public class KeyBinding : BaseData
    {

        private char _key;

        public char Key
        {
            get
            {
                if (this.validateChar(base.Value))
                {
                    return base.Value[0];
                }
                else
                {
                    return _key;
                }
            }
            set { _key = value; }
        }
        protected KeyBinding() : base()
        {

        }
        protected KeyBinding(char key) : base(key.ToString())
        {
            this._key = key;
        }

        private bool last
        {
            get
            {

                if (_key == 'z') { return true; } else { return false; }
            }
        }

        public override string ToString()
        {
            if (this.last)
            {
                return Key.ToString();
            }
            else
            {
                return base.ToString();
            }
        }


        private bool validateChar(string c)
        {
            if (!string.IsNullOrWhiteSpace(c) && c.Length == 1)
            {
                return true;
            }
            return false;

        }

        public static KeyBinding Create(char key)
        {
            return new KeyBinding(key);

        }
    }
}
