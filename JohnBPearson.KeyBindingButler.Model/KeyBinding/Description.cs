using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.KeyBindingButler.Model
{
    public class Description: BaseData
    {


      

      




        protected Description() : base()
            {

            }
            protected Description(string description) : base(description)
            {
              
            }

           
            public override string ToString()
            {
               return this.Value;
                
               
            }

        public static Description Create(string description)
        {
            return new Description(description);
        }
          
         
        }
    }