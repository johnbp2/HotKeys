using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.KeyBindingButler.Model
{
    public class Data : BaseData
    {


        private Data() {
            
        } 
        private Data(string value) : base(value) { 
     
        
        }

        private Data(object anyObject, ref object reference)
        {
            reference = anyObject;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static Data Create(string value)
        {
            return new Data(value);
        }

      
    }
}
