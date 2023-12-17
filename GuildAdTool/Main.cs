using JohnBPearson.Windows.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using JohnBPearson.KeyBindingButler.Model;
using JohnBPearson.Windows.Forms.Controls;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace JohnBPearson.Windows.Forms.KeyBindingButler
{
    public partial class Main : Form
    {


        #region private fields
        private JohnBPearson.Windows.Forms.Controls.NotBetterButton btnTest;
        private DataTable keyIndexTable;
        //  private string hotkeyModifiers = Properties.Settings.Default.HotkeyModifiers;
        private UserSettingsHelper userSettingsHelper;
        private KeyBoundValue currentItem;

        private ContextMenu contextMenuIcon;
        private MenuItem menuItemIcon;

        

        public KeyBoundValue selectedKeyBoundValue
        {
            get { if (cbHotkeySelection.SelectedItem != null) {
                    return cbHotkeySelection.SelectedItem as KeyBoundValue;

                } else
                {
                    return null;
                }
                }
    
        }

        //  private IPresenter<Form> presenter;
        #endregion
        public Main()
        {
            InitializeComponent();
            // var reminderForm = new Reminders();
            //this.presenter = presenter;
            //this.presenter.Form = this;
            this.userSettingsHelper = new UserSettingsHelper();
            this.setupTryIconMenu();
        }



        #region private methods



    
        private void copyToClipBoard(string data)
        {
            System.Windows.Clipboard.SetText(data);
            
        }





        private void registerHotKeys(List<KeyBoundValue> keys)
        {
            var index = 0;
            foreach (var item in keys)
            {


                var sb = new StringBuilder();
                sb.Append(Properties.Settings.Default.KeyBindingModifiers);
                sb.Append(item.Key);
                var del = new KeyBindCallBack(this.copyToClipBoard);
                    GlobalHotKey.RegisterHotKey(sb.ToString(), item.Value , del);





                index++;
            }
        }


        private void bindDropDownKeyValues()
        {



            this.cbHotkeySelection.Items.Clear();
            this.cbHotkeySelection.DataSource = this.userSettingsHelper.Items;
            //1  var currentHotKeyGuildAd = Properties.Settings.Default.UserHotKeyGuildAd.ToString();
            cbHotkeySelection.ValueMember = "Key";
         //   cbHotkeySelection.DisplayMember = "Key";
            
            // cbHotkeySelection.SelectedIndex = this.getIndexForKey(currentHotKeyGuildAd, this.keyIndexTable); //currentHotKeyGuildAd;



            //cbHotkey2.DataSource = this.setUpDatasource();

            //var currentHotKeyAcceptance = Properties.Settings.Default.UserHotkeyAcceptance.ToString();
            //cbHotkey2.ValueMember = Main.valueColumnName;
            //cbHotkey2.ValueMember = Main.indexColumnName;
            //cbHotkey2.SelectedItem = this.getIndexForKey(currentHotKeyAcceptance, this.keyIndexTable);

            //lbPlanetsList.DataSource = Planets.buildPlanetsList();
            // lbPlanetsList.DisplayMember = "Text";
            // lbPlanetsList.ValueMember = "Type";



        }


        //private int getIndexForKey(string key, DataTable keyIndexTable)
        //{
        //    //var rows = keyIndexTable.Select(String.Concat(Form1.valueColumnName," = '" , key , "'"));
        //    // var index = -1;

        //    foreach (DataRow row in keyIndexTable.Rows)
        //    {
        //        if (row.ItemArray[1].ToString() == key)
        //        {
        //            return int.Parse(row.ItemArray[0].ToString());
        //        }
        //    }
        //    //if (rows.FirstOrDefault() != null)
        //    //{

        //    //    int.TryParse( rows[0].ItemArray[0].ToString(), out index);

        //    //}
        //    return -1;
        //}
        
        private void setupTryIconMenu()        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuIcon = new System.Windows.Forms.ContextMenu();
            this.menuItemIcon = new System.Windows.Forms.MenuItem();

            // Initialize contextMenu1
            this.contextMenuIcon.MenuItems.AddRange(
                        new System.Windows.Forms.MenuItem[] { this.menuItemIcon });

            // Initialize menuItem1
            this.menuItemIcon.Index = 0;
            this.menuItemIcon.Text = "E&xit";
            this.menuItemIcon.Click += new System.EventHandler(this.menuItemIcon_Click);

    

      

 

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenuIcon;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon  
        }




        private void attemptToSave(bool overrideAutoSaveSetting)
        {
            //this.presenter.executeAutoSave((DataRowView)this.cbHotkey1.SelectedItem, (DataRowView)this.cbHotkey2.SelectedItem, new object(),
            // new object());
            if (Properties.Settings.Default.autoSave == true | overrideAutoSaveSetting)
            {
                if(this.userSettingsHelper != null && this.userSettingsHelper.updateItems(overrideAutoSaveSetting))
                {
                    FlashWindow.TrayAndWindow(this);
                }

                else
                {
                    System.Windows.Forms.MessageBox.Show("Did not save");
                }

            }
        }


        #endregion


        #region Events

        private void menuItemIcon_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            attemptToSave(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            attemptToSave(true);
            var popupNotifier = new PopupNotifier();

            popupNotifier.TitleText = "Title of popup";
            popupNotifier.ContentText = "Content text";
            popupNotifier.IsRightToLeft = false;
            popupNotifier.Popup();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
            else
            {

            }
            //  this.Size = new Size()
        }

        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {

            //.  this.cbHotkeySelection.ValueMember
            var actions = new List<Action<string>>();
            this.registerHotKeys(this.userSettingsHelper.Items);


            //Planets.buildPlanetsList();
           // var keysForActionBinding = userSettingsHelper.Keys;


            //   actions.Add(callBackActionGuildAd);
            //  lblHotkeyGuildAd.Text = string.Concat(Properties.Settings.Default.HotkeyModifiers, currentHotkeyGuildAd);
           

            //var callBackActionAcceptance = new Action<strin Hotkey2);
            //  actions.Add(callBackActionAcceptance); 
            //     var currentHotkeyAcceptance = Properties.Settings.Default.UserHotkeyAcceptance;
            //  lblHotkeyAcceptance.Text = string.Concat(Properties.Settings.Default.HotkeyModifiers, currentHotkeyAcceptance);
            //   keysForActionBinding.Add(currentHotkeyAcceptance.ToString());


            // this.registerHotKeys(keysForActionBinding, actions);
            this.bindDropDownKeyValues();


        
            //      this.tbHotkey2.Text = Properties.Settings.Default.hotkey2;

        }


        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            if (this.selectedKeyBoundValue != null) {
                var itemToUpdate = this.userSettingsHelper.Items.Find((item) =>
                {
                    if (item.Key == this.selectedKeyBoundValue.Key)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });
                itemToUpdate.Value = tbValue.Text;
                attemptToSave(false);
            }
        }






        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new SettingsDialog();
            settings.Show();
        }




        private void Main_Activated(object sender, EventArgs e)
        {
            FlashWindow.Stop(this);
        }

        private void notBetterButton2_Click(object sender, EventArgs e)
        {
            this.btnSave_Click(sender, e);

        }

        #endregion

        private void cbHotkeySelection_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.selectedKeyBoundValue != null)
            {
                tbValue.Text = this.selectedKeyBoundValue.Value;
              
            }

        }

    }
}
