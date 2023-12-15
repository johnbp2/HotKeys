using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnBPearson.Windows.Forms.KeyBindingButler
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
        Properties.Settings.Default.autoSave = rbAutoSaveOn.Checked;
         

                Properties.Settings.Default.MinimizeToTray = rbMinimizeToTrayOn.Checked;

        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            this.rbAutoSaveOff.Checked = !Properties.Settings.Default.autoSave;
            this.rbAutoSaveOn.Checked = Properties.Settings.Default.autoSave;

            this.rbMinimizeToTrayOn.Checked = Properties.Settings.Default.MinimizeToTray;
            this.rbMinimizeToTrayOff.Checked = !Properties.Settings.Default.MinimizeToTray;
        }

   
    }
}
