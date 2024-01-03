using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace JohnBPearson.Windows.Forms.Controls
{ public interface INotificationRoutine
    {
        void Popup(int index);
        void Popup();
    }
    public class ButlersNotificationRoutine : Tulpep.NotificationWindow.PopupNotifier, INotificationRoutine 
    {
        private List<Tuple<string, string>> _notifications;
        public void Popup()
        {
            this.Popup(0);
        }
        public void Popup(int index)
        {
            base.AnimationDuration = 2000;
            base.AnimationInterval = 10;
            base.TitleText = _notifications[index].Item1;
            base.ContentText = _notifications[index].Item2;
            base.Popup();
        }
        protected ButlersNotificationRoutine(List<Tuple<string, string>> notifications): base()
        {
            this._notifications = notifications;
        }

       public static INotificationRoutine Create(List<Tuple<string, string>> notifications)
        {
            return new ButlersNotificationRoutine(notifications);
        }

        public static INotificationRoutine Create(string title, string message)
        {
            
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            list.Add(new Tuple<string, string>(title, message));
            return new ButlersNotificationRoutine(list);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButlersNotificationRoutine));
            // 
            // ButlersNotificationRoutine
            // 
            this.AnimationDuration = 2000;
            this.Image = ((System.Drawing.Image)(resources.GetObject("$this.Image")));

        }
    }
}
