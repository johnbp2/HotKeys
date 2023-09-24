using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnBPearson.Windows.Forms
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var autoSave = rbAutoSaveOn.Checked;
        Properties.Settings.Default.autoSave = autoSave;
            Properties.Settings.Default.Save();
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            this.rbAutoSaveOff.Checked = !Properties.Settings.Default.autoSave;
            this.rbAutoSaveOn.Checked = Properties.Settings.Default.autoSave;
        }
    }
}
