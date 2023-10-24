using JohnBPearson.Windows.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using JohnBPearson.Windows.Forms.Recruiting;
using System.Data.SqlTypes;
using Tulpep.NotificationWindow;

namespace JohnBPearson.Windows.Forms
{
    public partial class Main : Form
    {


        #region private fields
        private JohnBPearson.Windows.Forms.Controls.NotBetterButton btnTest;
        private DataTable keyIndexTable;
      //  private string hotkeyModifiers = Properties.Settings.Default.HotkeyModifiers;
        private const string valueColumnName = "LetterValue";
        private const string indexColumnName = "Id";
      //  private IPresenter<Form> presenter;
        #endregion
        public Main()
        {
            InitializeComponent();
            // var reminderForm = new Reminders();
            //this.presenter = presenter;
            //this.presenter.Form = this;
           

        }

        #region private methods



        private void onHotkey1()
        {

            System.Windows.Clipboard.SetText(Properties.Settings.Default.hotkey1);
        }
        private void onHotkey2()
        {

            System.Windows.Clipboard.SetText(Properties.Settings.Default.hotkey2);
        }


       

        private DataTable setUpDatasource()
        {
            var letters = Properties.Settings.Default.AllowedHotkeys.Split(',').Clone();
            var tb = new DataTable("keyIndexTable");
            tb.Columns.Add(Main.indexColumnName, typeof(int));
            tb.Columns.Add(Main.valueColumnName, typeof(char));
            var index = 0;
            foreach (var key in letters as string[])
            {
                char newChar = char.Parse(key.Trim().ToLower());
                tb.Rows.Add(index, newChar);
                index++;
            }
            tb.AcceptChanges();
            return tb;
        }

        private void registerHotKeys(List<string> keys, List<Action> actions)
        {
            var index = 0;
            foreach (var key in keys)
            {


                var sb = new StringBuilder();
                sb.Append(Properties.Settings.Default.HotkeyModifiers);
                sb.Append(key);
                GlobalHotKey.RegisterHotKey(sb.ToString(), actions[index]);





                index++;
            }
        }


        private void bindAndCacheDatasource()
        {

            this.keyIndexTable = this.setUpDatasource();
            cbHotkey1.DataSource = this.keyIndexTable;

            var currentHotKeyGuildAd = Properties.Settings.Default.UserHotKeyGuildAd.ToString();
            cbHotkey1.ValueMember = Main.valueColumnName;
            cbHotkey1.ValueMember = Main.indexColumnName;

            cbHotkey1.SelectedIndex = this.getIndexForKey(currentHotKeyGuildAd, this.keyIndexTable); //currentHotKeyGuildAd;



            cbHotkey2.DataSource = this.setUpDatasource();

            var currentHotKeyAcceptance = Properties.Settings.Default.UserHotkeyAcceptance.ToString();
            cbHotkey2.ValueMember = Main.valueColumnName;
            cbHotkey2.ValueMember = Main.indexColumnName;
            cbHotkey2.SelectedItem = this.getIndexForKey(currentHotKeyAcceptance, this.keyIndexTable);

            //lbPlanetsList.DataSource = Planets.buildPlanetsList();
           // lbPlanetsList.DisplayMember = "Text";
           // lbPlanetsList.ValueMember = "Type";



        }


        private int getIndexForKey(string key, DataTable keyIndexTable)
        {
            //var rows = keyIndexTable.Select(String.Concat(Form1.valueColumnName," = '" , key , "'"));
            // var index = -1;

            foreach (DataRow row in keyIndexTable.Rows)
            {
                if (row.ItemArray[1].ToString() == key)
                {
                    return int.Parse(row.ItemArray[0].ToString());
                }
            }
            //if (rows.FirstOrDefault() != null)
            //{

            //    int.TryParse( rows[0].ItemArray[0].ToString(), out index);

            //}
            return -1;
        }


        private void copyToClipBoard(string textToCopy)
        {


        }

        private void attemptToSave(bool overrideAutoSaveSetting)
        {
            this.attemptToSave(overrideAutoSaveSetting, null, null);
        }

        private void attemptToSave(bool overrideAutoSaveSetting, object setting, object value)
        {
            //this.presenter.executeAutoSave((DataRowView)this.cbHotkey1.SelectedItem, (DataRowView)this.cbHotkey2.SelectedItem, new object(),
            // new object());
            if (Properties.Settings.Default.autoSave == true | overrideAutoSaveSetting)
            {

                FlashWindow.TrayAndWindow(this);

                var row = (DataRowView)this.cbHotkey1.SelectedItem;
                char t = char.Parse(row.Row.ItemArray[1].ToString());
                Properties.Settings.Default.UserHotKeyGuildAd = t;
                row = (DataRowView)this.cbHotkey2.SelectedItem;
                t = char.Parse(row.Row.ItemArray[1].ToString());
                Properties.Settings.Default.UserHotkeyAcceptance = t;
                Properties.Settings.Default.Save();
            }
        }
        #endregion


        #region Events


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
            //  this.Size = new Size()
        }

        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Planets.buildPlanetsList();
            var keysForActionBinding = new List<string>();
            var actions = new List<Action>();

            var callBackActionGuildAd = new Action(this.onHotkey1);
            actions.Add(callBackActionGuildAd);
            var currentHotkeyGuildAd = Properties.Settings.Default.UserHotKeyGuildAd;
            lblHotkeyGuildAd.Text = string.Concat(Properties.Settings.Default.HotkeyModifiers, currentHotkeyGuildAd);
            keysForActionBinding.Add(currentHotkeyGuildAd.ToString());

            var callBackActionAcceptance = new Action(this.onHotkey2);
            actions.Add(callBackActionAcceptance); 
            var currentHotkeyAcceptance = Properties.Settings.Default.UserHotkeyAcceptance;
            lblHotkeyAcceptance.Text = string.Concat(Properties.Settings.Default.HotkeyModifiers, currentHotkeyAcceptance);
            keysForActionBinding.Add(currentHotkeyAcceptance.ToString());

            this.registerHotKeys(keysForActionBinding, actions);
            this.bindAndCacheDatasource();


            this.tbHotkey1.Text = Properties.Settings.Default.hotkey1;
            this.tbHotkey2.Text = Properties.Settings.Default.hotkey2;

        }
        private void tbHotkey1_TextChanged(object sender, EventArgs e)
        {
            attemptToSave(false);
        }

        private void tbHotkey2_TextChanged(object sender, EventArgs e)
        {
            attemptToSave(false);
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
    }
}
