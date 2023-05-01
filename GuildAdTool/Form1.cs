using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;

namespace JohnBPearson.Windows.Forms
{
    public partial class Form1 : Form
    {

        private DataTable keyIndexTable;
        private string hotkeyModifiers = Properties.Settings.Default.HotkeyModifiers;
        private const string valueColumnName = "LetterValue";
        private const string indexColumnName = "Id";
        public Form1()
        {
            InitializeComponent();
        }




        private void callBackForHotkeyGuildAd()
        {

            Clipboard.SetText(Properties.Settings.Default.GuildAd);
        }
        private void callBackForHotkeyAcceptance()
        {

            Clipboard.SetText(Properties.Settings.Default.AcceptanceMessage);
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
            tb.Columns.Add(Form1.indexColumnName, typeof(int));
            tb.Columns.Add(Form1.valueColumnName, typeof(char));
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
            cbHotkeyGuildAd.ValueMember = Form1.valueColumnName;
            cbHotkeyGuildAd.ValueMember = Form1.indexColumnName;

            cbHotkeyGuildAd.SelectedIndex = this.getIndexForKey(currentHotKeyGuildAd, this.keyIndexTable); //currentHotKeyGuildAd;



            cbHotkeyAcceptance.DataSource = this.setUpDatasource();

            var currentHotKeyAcceptance = Properties.Settings.Default.UserHotkeyAcceptance.ToString();
            cbHotkeyAcceptance.ValueMember = Form1.valueColumnName;
            cbHotkeyAcceptance.ValueMember = Form1.indexColumnName;
            cbHotkeyAcceptance.SelectedItem = this.getIndexForKey(currentHotKeyAcceptance, this.keyIndexTable);


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
        }

        private void tbAcceptance_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.AcceptanceMessage = tbAcceptance.Text;
        }
        #endregion  
    }
}
