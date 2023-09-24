using JohnBPearson.Windows.Interop;

namespace JohnBPearson.Windows.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparentFlowPanel1 = new JohnBPearson.Windows.Forms.Controls.TransparentFlowPanel();
            this.lblHotkeyGuildAd = new System.Windows.Forms.Label();
            this.cbHotkey1 = new System.Windows.Forms.ComboBox();
            this.transparentFlowPanel2 = new JohnBPearson.Windows.Forms.Controls.TransparentFlowPanel();
            this.lblHotkeyAcceptance = new System.Windows.Forms.Label();
            this.cbHotkey2 = new System.Windows.Forms.ComboBox();
            this.transparentPanel2 = new JohnBPearson.Windows.Forms.Controls.TransparentPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGuildAd = new System.Windows.Forms.Label();
            this.lblAcceptance = new System.Windows.Forms.Label();
            this.tbHotkey2 = new System.Windows.Forms.TextBox();
            this.tbHotkey1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.transparentFlowPanel1.SuspendLayout();
            this.transparentFlowPanel2.SuspendLayout();
            this.transparentPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "The butler is in";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // transparentFlowPanel1
            // 
            this.transparentFlowPanel1.Controls.Add(this.lblHotkeyGuildAd);
            this.transparentFlowPanel1.Controls.Add(this.cbHotkey1);
            this.transparentFlowPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.transparentFlowPanel1.Location = new System.Drawing.Point(42, 39);
            this.transparentFlowPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.transparentFlowPanel1.Name = "transparentFlowPanel1";
            this.transparentFlowPanel1.Size = new System.Drawing.Size(268, 78);
            this.transparentFlowPanel1.TabIndex = 2;
            // 
            // lblHotkeyGuildAd
            // 
            this.lblHotkeyGuildAd.AutoSize = true;
            this.lblHotkeyGuildAd.Location = new System.Drawing.Point(6, 0);
            this.lblHotkeyGuildAd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHotkeyGuildAd.Name = "lblHotkeyGuildAd";
            this.lblHotkeyGuildAd.Size = new System.Drawing.Size(157, 29);
            this.lblHotkeyGuildAd.TabIndex = 0;
            this.lblHotkeyGuildAd.Text = "Alt +  Shift + ?";
            // 
            // cbHotkey1
            // 
            this.cbHotkey1.FormattingEnabled = true;
            this.cbHotkey1.Location = new System.Drawing.Point(6, 35);
            this.cbHotkey1.Margin = new System.Windows.Forms.Padding(6);
            this.cbHotkey1.Name = "cbHotkey1";
            this.cbHotkey1.Size = new System.Drawing.Size(218, 37);
            this.cbHotkey1.TabIndex = 0;
            // 
            // transparentFlowPanel2
            // 
            this.transparentFlowPanel2.Controls.Add(this.lblHotkeyAcceptance);
            this.transparentFlowPanel2.Controls.Add(this.cbHotkey2);
            this.transparentFlowPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.transparentFlowPanel2.Location = new System.Drawing.Point(471, 39);
            this.transparentFlowPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.transparentFlowPanel2.Name = "transparentFlowPanel2";
            this.transparentFlowPanel2.Size = new System.Drawing.Size(264, 81);
            this.transparentFlowPanel2.TabIndex = 2;
            // 
            // lblHotkeyAcceptance
            // 
            this.lblHotkeyAcceptance.AutoSize = true;
            this.lblHotkeyAcceptance.Location = new System.Drawing.Point(6, 0);
            this.lblHotkeyAcceptance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHotkeyAcceptance.Name = "lblHotkeyAcceptance";
            this.lblHotkeyAcceptance.Size = new System.Drawing.Size(157, 29);
            this.lblHotkeyAcceptance.TabIndex = 2;
            this.lblHotkeyAcceptance.Text = "Alt +  Shift + ?";
            // 
            // cbHotkey2
            // 
            this.cbHotkey2.FormattingEnabled = true;
            this.cbHotkey2.Location = new System.Drawing.Point(6, 35);
            this.cbHotkey2.Margin = new System.Windows.Forms.Padding(6);
            this.cbHotkey2.Name = "cbHotkey2";
            this.cbHotkey2.Size = new System.Drawing.Size(218, 37);
            this.cbHotkey2.TabIndex = 1;
            // 
            // transparentPanel2
            // 
            this.transparentPanel2.Controls.Add(this.btnSave);
            this.transparentPanel2.Controls.Add(this.lblGuildAd);
            this.transparentPanel2.Controls.Add(this.lblAcceptance);
            this.transparentPanel2.Controls.Add(this.tbHotkey2);
            this.transparentPanel2.Controls.Add(this.tbHotkey1);
            this.transparentPanel2.Location = new System.Drawing.Point(11, 128);
            this.transparentPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.transparentPanel2.Name = "transparentPanel2";
            this.transparentPanel2.Size = new System.Drawing.Size(917, 238);
            this.transparentPanel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(832, 100);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGuildAd
            // 
            this.lblGuildAd.AutoSize = true;
            this.lblGuildAd.Location = new System.Drawing.Point(26, 7);
            this.lblGuildAd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGuildAd.Name = "lblGuildAd";
            this.lblGuildAd.Size = new System.Drawing.Size(422, 29);
            this.lblGuildAd.TabIndex = 3;
            this.lblGuildAd.Text = "Text to copy when hotkey 1 is invoked ";
            // 
            // lblAcceptance
            // 
            this.lblAcceptance.AutoSize = true;
            this.lblAcceptance.Location = new System.Drawing.Point(455, 7);
            this.lblAcceptance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAcceptance.Name = "lblAcceptance";
            this.lblAcceptance.Size = new System.Drawing.Size(422, 29);
            this.lblAcceptance.TabIndex = 2;
            this.lblAcceptance.Text = "Text to copy when hotkey 2 is invoked ";
            // 
            // tbHotkey2
            // 
            this.tbHotkey2.BackColor = System.Drawing.SystemColors.Info;
            this.tbHotkey2.Location = new System.Drawing.Point(455, 46);
            this.tbHotkey2.Margin = new System.Windows.Forms.Padding(6);
            this.tbHotkey2.Multiline = true;
            this.tbHotkey2.Name = "tbHotkey2";
            this.tbHotkey2.Size = new System.Drawing.Size(363, 142);
            this.tbHotkey2.TabIndex = 1;
            this.tbHotkey2.TabStop = false;
            this.tbHotkey2.TextChanged += new System.EventHandler(this.tbHotkey2_TextChanged);
            // 
            // tbHotkey1
            // 
            this.tbHotkey1.BackColor = System.Drawing.SystemColors.Info;
            this.tbHotkey1.Location = new System.Drawing.Point(31, 46);
            this.tbHotkey1.Margin = new System.Windows.Forms.Padding(6);
            this.tbHotkey1.Multiline = true;
            this.tbHotkey1.Name = "tbHotkey1";
            this.tbHotkey1.Size = new System.Drawing.Size(363, 142);
            this.tbHotkey1.TabIndex = 0;
            this.tbHotkey1.TabStop = false;
            this.tbHotkey1.TextChanged += new System.EventHandler(this.tbHotkey1_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 387);
            this.Controls.Add(this.transparentFlowPanel1);
            this.Controls.Add(this.transparentFlowPanel2);
            this.Controls.Add(this.transparentPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Butler copy my...";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.transparentFlowPanel1.ResumeLayout(false);
            this.transparentFlowPanel1.PerformLayout();
            this.transparentFlowPanel2.ResumeLayout(false);
            this.transparentFlowPanel2.PerformLayout();
            this.transparentPanel2.ResumeLayout(false);
            this.transparentPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private JohnBPearson.Windows.Forms.Controls.TransparentPanel transparentPanel2;
        private System.Windows.Forms.TextBox tbHotkey1;
        private System.Windows.Forms.Label lblGuildAd;
        private System.Windows.Forms.Label lblAcceptance;
        private System.Windows.Forms.TextBox tbHotkey2;
        private System.Windows.Forms.Button btnSave;
        private JohnBPearson.Windows.Forms.Controls.TransparentFlowPanel transparentFlowPanel1;
        private System.Windows.Forms.Label lblHotkeyGuildAd;
        private System.Windows.Forms.ComboBox cbHotkey1;
        private Controls.TransparentFlowPanel transparentFlowPanel2;
        private System.Windows.Forms.Label lblHotkeyAcceptance;
        private System.Windows.Forms.ComboBox cbHotkey2;
       // private System.Windows.Forms.Button btnCopyGuildLog;
       // private Controls.TransparentPanel transparentPanel1;
       // private System.Windows.Forms.ListBox lbPlanetsList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

