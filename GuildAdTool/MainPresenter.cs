using JohnBPearson.Windows.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnBPearson.Windows.Forms
{
    public class MainPresenter : IPresenter
    {

        public Form form { get; set; }

        public bool overrideAutoSaveSetting = false;

        public MainPresenter() { }


            public void executeAutoSave(object settingsObject, object value, DataRowView hotkey1, DataRowView hotkey2)
            {

                if (Properties.Settings.Default.autoSave == true | overrideAutoSaveSetting)
                {

                    FlashWindow.TrayAndWindow(this.form);

                   
                    char t = char.Parse(hotkey1.Row.ItemArray[1].ToString());
                    Properties.Settings.Default.UserHotKeyGuildAd = t;
                    
                    t = char.Parse(hotkey2.Row.ItemArray[1].ToString());
                    Properties.Settings.Default.UserHotkeyAcceptance = t;

                    settingsObject = value;
                    settingsObject = value;
                    Properties.Settings.Default.Save();
                }

            }
        }
    }

    public interface IPresenter
    {
         Form form { get; set; }

       void executeAutoSave(object settingsObject, object value, DataRowView hotkey1, DataRowView hotkey2);
    }
}
