using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JohnBPearson.Windows.Forms.Controls;
using JohnBPearson.Windows.Interop;
using Tulpep.NotificationWindow;

namespace JohnBPearson.Windows.Forms.KeyBindingButler
{
    public partial class BaseForm : System.Windows.Forms.Form
    {

        protected PopupNotifier notifier = new PopupNotifier();


        protected void notify(string title, string content)
        {
            Bitmap bmp = new Bitmap(@".\Butler.png");

            var popupNotifier = Notification.Create(title, content, bmp);

            //((System.Drawing.Image)(resources.GetObject("popupNotifier1.Image")));1
            using (popupNotifier as IDisposable)
            {

                popupNotifier.Popup();

            }
          )
            FlashWindow.TrayAndWindow(this);
        }
    }

    }
