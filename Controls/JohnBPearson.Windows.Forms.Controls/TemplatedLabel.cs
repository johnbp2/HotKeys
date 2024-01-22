using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.Windows.Forms.Controls
{
    public class TemplatedLabel: System.Windows.Forms.Label
    {

		private string _template;

		public string Template
		{
			get { return _template; }
			set { _template = value;
			if(TemplateValues != null)
				{
					try
					{
                        base.Text = String.Format(Template, TemplateValues);
                    }
					catch (FormatException ex)
					{

						throw ex;
					}
				
				}
			}
		}

		private string[] _templateValues;

		public string[] TemplateValues
		{ get { return _templateValues; } set { _templateValues = value; } }


        public new string Text { get => base.Text; private set => base.Text = value; }
    }
}
