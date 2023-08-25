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

namespace JohnBPearson.Windows.Forms
{
    public partial class Main : Form
    {
        #region private fields

        private DataTable keyIndexTable;
        private string hotkeyModifiers = Properties.Settings.Default.HotkeyModifiers;
        private const string valueColumnName = "LetterValue";
        private const string indexColumnName = "Id"; 
        #endregion
        public Main()
        {
            InitializeComponent();
            var reminderForm = new Reminders();

        }

        #region private methods



        private void callBackForHotkeyGuildAd()
        {

            System.Windows.Clipboard.SetText(Properties.Settings.Default.GuildAd);
        }
        private void callBackForHotkeyAcceptance()
        {

            System.Windows.Clipboard.SetText(Properties.Settings.Default.AcceptanceMessage);
        }


        private void saveSettings()
        {
            var row = (DataRowView)this.cbHotkeyGuildAd.SelectedItem;
            char t = char.Parse(row.Row.ItemArray[1].ToString());
            Properties.Settings.Default.UserHotKeyGuildAd = t;
            row = (DataRowView)this.cbHotkeyAcceptance.SelectedItem;
            t = char.Parse(row.Row.ItemArray[1].ToString());
            Properties.Settings.Default.UserHotkeyAcceptance = t;
            Properties.Settings.Default.Save();
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
                sb.Append(this.hotkeyModifiers);
                sb.Append(key);
                GlobalHotKey.RegisterHotKey(sb.ToString(), actions[index]);





                index++;
            }
        }


        private void bindAndCacheDatasource()
        {

            this.keyIndexTable = this.setUpDatasource();
            cbHotkeyGuildAd.DataSource = this.keyIndexTable;

            var currentHotKeyGuildAd = Properties.Settings.Default.UserHotKeyGuildAd.ToString();
            cbHotkeyGuildAd.ValueMember = Main.valueColumnName;
            cbHotkeyGuildAd.ValueMember = Main.indexColumnName;

            cbHotkeyGuildAd.SelectedIndex = this.getIndexForKey(currentHotKeyGuildAd, this.keyIndexTable); //currentHotKeyGuildAd;



            cbHotkeyAcceptance.DataSource = this.setUpDatasource();

            var currentHotKeyAcceptance = Properties.Settings.Default.UserHotkeyAcceptance.ToString();
            cbHotkeyAcceptance.ValueMember = Main.valueColumnName;
            cbHotkeyAcceptance.ValueMember = Main.indexColumnName;
            cbHotkeyAcceptance.SelectedItem = this.getIndexForKey(currentHotKeyAcceptance, this.keyIndexTable);

            lbPlanetsList.DataSource = Planets.buildPlanetsList();
            lbPlanetsList.DisplayMember = "Text";
            lbPlanetsList.ValueMember = "Type";



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
        #endregion


        #region Events


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{


            //  Properties.Settings.Default.UserHotKeyGuildAd  = 

          var row =  (DataRowView)this.cbHotkeyGuildAd.SelectedItem;
           char t =     char.Parse( row.Row.ItemArray[1].ToString());
            Properties.Settings.Default.UserHotKeyGuildAd = t;
            row= (DataRowView)this.cbHotkeyAcceptance.SelectedItem;
             t = char.Parse(row.Row.ItemArray[1].ToString());
            Properties.Settings.Default.UserHotkeyAcceptance = t;
            Properties.Settings.Default.Save();

            //}
            //catch (Exception ex)
            //{

            // } 
        }

        private void Form1_Resize(object sender, EventArgs e)
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
            Planets.buildPlanetsList();
            var keysForActionBinding = new List<string>();
            var actions = new List<Action>();

            var callBackActionGuildAd = new Action(this.callBackForHotkeyGuildAd);
            actions.Add(callBackActionGuildAd);
            var currentHotkeyGuildAd = Properties.Settings.Default.UserHotKeyGuildAd;
            lblHotkeyGuildAd.Text = string.Concat(this.hotkeyModifiers, currentHotkeyGuildAd);
            keysForActionBinding.Add(currentHotkeyGuildAd.ToString());

            var callBackActionAcceptance = new Action(this.callBackForHotkeyAcceptance);
            actions.Add(callBackActionAcceptance);
            var currentHotkeyAcceptance = Properties.Settings.Default.UserHotkeyAcceptance;
            lblHotkeyAcceptance.Text = string.Concat(this.hotkeyModifiers, currentHotkeyAcceptance);
            keysForActionBinding.Add(currentHotkeyAcceptance.ToString());

            this.registerHotKeys(keysForActionBinding, actions);
            this.bindAndCacheDatasource();


            this.tbGuildAd.Text = Properties.Settings.Default.GuildAd;
            this.tbAcceptance.Text = Properties.Settings.Default.AcceptanceMessage;

        }
        private void tbGuildAd_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GuildAd = tbGuildAd.Text;
            Properties.Settings.Default.Save(); 
        }

        private void tbAcceptance_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.AcceptanceMessage = tbAcceptance.Text;
            Properties.Settings.Default.Save();
        }
      

        private void btnCopyGuildLog_Click(object sender, EventArgs e)
        {
          
            if (lbPlanetsList.SelectedItems.Count > 0)
            {

                var logEntry = new RecruiterLogEntry();
           var logString = logEntry.CreateLogEntry(lbPlanetsList.SelectedItems);
            // cache whats in there
        var cachedString = System.Windows.Clipboard.GetText();
                System.Windows.Clipboard.SetText(logString);
               // string[] message = { };
                Utilities.MyMessageBox("Click ok after pasting into discord.", "");
                System.Windows.Clipboard.SetText(cachedString);

            }
        }

     
        #endregion
    }
}
