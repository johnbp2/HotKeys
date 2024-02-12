using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Navigation;
using JohnBPearson.KeyBindingButler.Model;


namespace JohnBPearson.Windows.Forms.KeyBindingButler
{
    public interface IPresenterBase : INotifyPropertyChanged
    {

    }


    public class MainPresenter : IPresenter<Main>
    {
        private JohnBPearson.KeyBindingButler.Model.KeyBoundDataList keyBoundValueList;
        private Main _main;
        public Main Form { get { return this._main; } private set { this._main = value; } }


        public void replaceItem(IKeyBoundData oldItem, string newValue)
        {
            if (oldItem.Data.Value != newValue)
            {
                this.keyBoundValueList.Replace(oldItem.Recreate(newValue), oldItem);
            }
        }
        public int executeAutoSave(bool overrideAutoSaveSetting)
        {
            var strings = this.keyBoundValueList.PrepareDataForSave();
            Properties.Settings.Default.BindableValues = strings.Values;
            Properties.Settings.Default.Save();
            return 0;
        }
        public IEnumerable<string> Keys
        {
            get
            {
                if (this.keyBoundValueList == null)
                {
                    this.LoadHotKeyValues();

                }
                return this.keyBoundValueList.Keys;
            }
        }
        public IEnumerable<JohnBPearson.KeyBindingButler.Model.IKeyBoundData> HotKeyValues
        {
            get
            {
                if (this.keyBoundValueList == null)
                {
                    LoadHotKeyValues();
                }
                return this.keyBoundValueList.Items;
            }

        }

        public IKeyBoundData findKeyBoundValue(string keyValue)
        {
          return  this.HotKeyValues.ToList<IKeyBoundData>().Find((item) => { return item.Key.Value == keyValue; });

        }
        private void LoadHotKeyValues()
        {
            var strings = new KeyAndDataStringLiterals();
            strings.Values = Properties.Settings.Default.BindableValues;
            strings.Keys = Properties.Settings.Default.BindableKeys;
            
            this.keyBoundValueList = new JohnBPearson.KeyBindingButler.Model.KeyBoundDataList(strings);
        }
    }



    public interface IPresenter<T>
    {
        T Form { get; }

        int executeAutoSave(bool overrideAutoSaveSetting);
    }





}
