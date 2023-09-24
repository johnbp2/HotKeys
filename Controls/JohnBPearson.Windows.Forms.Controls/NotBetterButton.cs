using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBPearson.Windows.Forms.Controls
{
    public class NotBetterButton : System.Windows.Forms.Button
    {

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.BackColor = System.Drawing.Color.Red;
        }
    }
}
