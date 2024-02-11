using JohnBPearson.Windows.Interop;
using JohnBPearson.Windows.Forms.Controls;

namespace JohnBPearson.Windows.Forms.KeyBindingButler
{/// <summary>
/// 
/// </summary>
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
            this.cbHotkeySelection = new System.Windows.Forms.ComboBox();
            this.transparentPanel2 = new JohnBPearson.Windows.Forms.Controls.TransparentPanel();
            this.notBetterButton2 = new JohnBPearson.Windows.Forms.Controls.NotBetterButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGuildAd = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.transparentFlowPanel1.SuspendLayout();
            this.transparentPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "The butler is in";
            this.notifyIcon1.BalloonTipTitle = "Key Binding Butler";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "The \"Key Binding Butler\" is in";
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
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // transparentFlowPanel1
            // 
            this.transparentFlowPanel1.Controls.Add(this.lblHotkeyGuildAd);
            this.transparentFlowPanel1.Controls.Add(this.cbHotkeySelection);
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
            this.lblHotkeyGuildAd.Size = new System.Drawing.Size(123, 24);
            this.lblHotkeyGuildAd.TabIndex = 0;
            this.lblHotkeyGuildAd.Text = "Alt +  Shift + ?";
            // 
            // cbHotkeySelection
            // 
            this.cbHotkeySelection.FormattingEnabled = true;
            this.cbHotkeySelection.Location = new System.Drawing.Point(6, 30);
            this.cbHotkeySelection.Margin = new System.Windows.Forms.Padding(6);
            this.cbHotkeySelection.Name = "cbHotkeySelection";
            this.cbHotkeySelection.Size = new System.Drawing.Size(218, 32);
            this.cbHotkeySelection.TabIndex = 0;
            this.cbHotkeySelection.SelectedValueChanged += new System.EventHandler(this.cbHotkeySelection_SelectedValueChanged);
            // 
            // transparentPanel2
            // 
            this.transparentPanel2.Controls.Add(this.notBetterButton2);
            this.transparentPanel2.Controls.Add(this.btnSave);
            this.transparentPanel2.Controls.Add(this.lblGuildAd);
            this.transparentPanel2.Controls.Add(this.tbValue);
            this.transparentPanel2.Location = new System.Drawing.Point(11, 128);
            this.transparentPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.transparentPanel2.Name = "transparentPanel2";
            this.transparentPanel2.Size = new System.Drawing.Size(917, 238);
            this.transparentPanel2.TabIndex = 1;
            // 
            // notBetterButton2
            // 
            this.notBetterButton2.DisplayText = "Save";
            this.notBetterButton2.EndColor = System.Drawing.Color.DarkBlue;
            this.notBetterButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notBetterButton2.ForeColor = System.Drawing.Color.White;
            this.notBetterButton2.GradientAngle = 90;
            this.notBetterButton2.Location = new System.Drawing.Point(845, 147);
            this.notBetterButton2.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.notBetterButton2.MouseClickColor2 = System.Drawing.Color.Red;
            this.notBetterButton2.MouseHoverColor1 = System.Drawing.Color.Yellow;
            this.notBetterButton2.MouseHoverColor2 = System.Drawing.Color.DarkOrange;
            this.notBetterButton2.Name = "notBetterButton2";
            this.notBetterButton2.Size = new System.Drawing.Size(69, 41);
            this.notBetterButton2.StartColor = System.Drawing.Color.LightGreen;
            this.notBetterButton2.TabIndex = 4;
            this.notBetterButton2.Text = "Save";
            this.notBetterButton2.TextLocation_X = 76;
            this.notBetterButton2.TextLocation_Y = 24;
            this.notBetterButton2.Transparent1 = 150;
            this.notBetterButton2.Transparent2 = 150;
            this.notBetterButton2.UseVisualStyleBackColor = true;
            this.notBetterButton2.Visible = false;
            this.notBetterButton2.Click += new System.EventHandler(this.notBetterButton2_Click);
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
            this.lblGuildAd.Size = new System.Drawing.Size(0, 24);
            this.lblGuildAd.TabIndex = 3;
            // 
            // tbValue
            // 
            this.tbValue.BackColor = System.Drawing.SystemColors.Info;
            this.tbValue.Location = new System.Drawing.Point(31, 46);
            this.tbValue.Margin = new System.Windows.Forms.Padding(6);
            this.tbValue.Multiline = true;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(363, 142);
            this.tbValue.TabIndex = 0;
            this.tbValue.TabStop = false;
            this.tbValue.Leave += new System.EventHandler(this.tbValue_Leave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 387);
            this.Controls.Add(this.transparentFlowPanel1);
            this.Controls.Add(this.transparentPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Butler copy my...";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.transparentFlowPanel1.ResumeLayout(false);
            this.transparentFlowPanel1.PerformLayout();
            this.transparentPanel2.ResumeLayout(false);
            this.transparentPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private JohnBPearson.Windows.Forms.Controls.TransparentPanel transparentPanel2;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lblGuildAd;
        private System.Windows.Forms.Button btnSave;
        private JohnBPearson.Windows.Forms.Controls.TransparentFlowPanel transparentFlowPanel1;
        private System.Windows.Forms.Label lblHotkeyGuildAd;
        private System.Windows.Forms.ComboBox cbHotkeySelection;
       // private System.Windows.Forms.Button btnCopyGuildLog;
       // private Controls.TransparentPanel transparentPanel1;
       // private System.Windows.Forms.ListBox lbPlanetsList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private JohnBPearson.Windows.Forms.Controls.NotBetterButton notBetterButton2;
    }
}

