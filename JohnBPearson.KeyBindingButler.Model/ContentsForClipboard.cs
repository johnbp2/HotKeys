using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.KeyBindingButler.Model
{
    public class ContentsForClipboard : BaseData
    {


        private ContentsForClipboard() {
            
        } 
        private ContentsForClipboard(string value) : base(value) { 
     
        
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public static ContentsForClipboard Create(string value)
        {
            return new ContentsForClipboard(value);
        }

    }
}
