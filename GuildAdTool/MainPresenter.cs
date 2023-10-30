using JohnBPearson.Windows.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnBPearson.Windows.Forms
{
public interface IPresenterBase : INotifyPropertyChanged
{

}


    //    public MainPresenter(ISettingsProvider settingsProv) 
    //    { 
    //    this.settingsProvider = settingsProv;  
    //    }

    //    private Main form;
    //    public Main Form { get => this.form; set => form = value; }

    //    //  public MainPresenter form { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    // Main IPresenter<Main>.form { get; set; }

    //    public void executeAutoSave(DataRowView hotkey1, DataRowView hotkey2
    //    , object settingsObject = null, object value = null, bool overrideAutoSaveSetting = false)
    //    {
    //        if (settingsObject != null && value != null)
    //        {
    //            settingsObject = value;
    //            this.settingsProvider.Save();
    //        }
    //        else
    //        {

    //            if (Properties.Settings.Default.autoSave == true | overrideAutoSaveSetting)
    //            {

    //                FlashWindow.TrayAndWindow(this.form);



            }
        }
    

    //                char t = char.Parse(hotkey1.Row.ItemArray[1].ToString());
    //                Properties.Settings.Default.UserHotKeyGuildAd = t;

    //                t = char.Parse(hotkey2.Row.ItemArray[1].ToString());
    //                Properties.Settings.Default.UserHotkeyAcceptance = t;


    //                settingsObject = value;
    //                settingsObject = value;
    //                this.settingsProvider.Save();
    //            }
    //        }
    //    }
    //}


    public interface IPresenter<T>
    {
        T Form { get; set; }

        void executeAutoSave(DataRowView hotkey1, DataRowView hotkey2
        , object settingsObject = null, object value = null, bool overrideAutoSaveSetting = false);
    }



    //public interface ISettingsProvider
    //{

    //    bool AutoSave {
    //        get;
    //    }

    //    void Save();

    //}

    //public class SettingsWrapper : ISettingsProvider
    //{

    //private SettingsBase settings;
    //    public SettingsWrapper(SettingsBase settings)
    //    {
    //        this.settings = settings;


    //    }

    //    public bool AutoSave
    //    {
    //        get {
    //            try
    //            {
    //                var temp = (JohnBPearson.Windows.Forms.Properties.Settings)this.settings;
    //                return temp.autoSave;
    //            }
    //            catch (Exception ex) {
    //            return false;
    //            }
    //        }
           
    //    }

    //    public void Save()
    //    {
    //        this.settings.Save();
    //    }
    //}

}
