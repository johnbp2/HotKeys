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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            transparentFlowPanel1 = new TransparentFlowPanel();
            lblHotkeyGuildAd = new System.Windows.Forms.Label();
            cbHotkeySelection = new System.Windows.Forms.ComboBox();
            transparentPanel2 = new TransparentPanel();
            notBetterButton2 = new NotBetterButton();
            btnSave = new System.Windows.Forms.Button();
            lblGuildAd = new System.Windows.Forms.Label();
            tbValue = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            transparentFlowPanel1.SuspendLayout();
            transparentPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "The butler is in";
            notifyIcon1.BalloonTipTitle = "Key Binding Butler";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "The \"Key Binding Butler\" is in";
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            toolStripMenuItem1.Text = "Exit";
            // 
            // transparentFlowPanel1
            // 
            transparentFlowPanel1.Controls.Add(lblHotkeyGuildAd);
            transparentFlowPanel1.Controls.Add(cbHotkeySelection);
            transparentFlowPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            transparentFlowPanel1.Location = new System.Drawing.Point(42, 39);
            transparentFlowPanel1.Margin = new System.Windows.Forms.Padding(6);
            transparentFlowPanel1.Name = "transparentFlowPanel1";
            transparentFlowPanel1.Size = new System.Drawing.Size(268, 78);
            transparentFlowPanel1.TabIndex = 2;
            // 
            // lblHotkeyGuildAd
            // 
            lblHotkeyGuildAd.AutoSize = true;
            lblHotkeyGuildAd.Location = new System.Drawing.Point(6, 0);
            lblHotkeyGuildAd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblHotkeyGuildAd.Name = "lblHotkeyGuildAd";
            lblHotkeyGuildAd.Size = new System.Drawing.Size(123, 24);
            lblHotkeyGuildAd.TabIndex = 0;
            lblHotkeyGuildAd.Text = "Alt +  Shift + ?";
            // 
            // cbHotkeySelection
            // 
            cbHotkeySelection.FormattingEnabled = true;
            cbHotkeySelection.Location = new System.Drawing.Point(6, 30);
            cbHotkeySelection.Margin = new System.Windows.Forms.Padding(6);
            cbHotkeySelection.Name = "cbHotkeySelection";
            cbHotkeySelection.Size = new System.Drawing.Size(218, 32);
            cbHotkeySelection.TabIndex = 0;
            cbHotkeySelection.SelectedValueChanged += cbHotkeySelection_SelectedValueChanged;
            // 
            // transparentPanel2
            // 
            transparentPanel2.Controls.Add(notBetterButton2);
            transparentPanel2.Controls.Add(btnSave);
            transparentPanel2.Controls.Add(lblGuildAd);
            transparentPanel2.Controls.Add(tbValue);
            transparentPanel2.Location = new System.Drawing.Point(11, 128);
            transparentPanel2.Margin = new System.Windows.Forms.Padding(6);
            transparentPanel2.Name = "transparentPanel2";
            transparentPanel2.Size = new System.Drawing.Size(917, 238);
            transparentPanel2.TabIndex = 1;
            // 
            // notBetterButton2
            // 
            notBetterButton2.DisplayText = "Save";
            notBetterButton2.EndColor = System.Drawing.Color.DarkBlue;
            notBetterButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            notBetterButton2.ForeColor = System.Drawing.Color.White;
            notBetterButton2.GradientAngle = 90;
            notBetterButton2.Location = new System.Drawing.Point(845, 147);
            notBetterButton2.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            notBetterButton2.MouseClickColor2 = System.Drawing.Color.Red;
            notBetterButton2.MouseHoverColor1 = System.Drawing.Color.Yellow;
            notBetterButton2.MouseHoverColor2 = System.Drawing.Color.DarkOrange;
            notBetterButton2.Name = "notBetterButton2";
            notBetterButton2.Size = new System.Drawing.Size(69, 41);
            notBetterButton2.StartColor = System.Drawing.Color.LightGreen;
            notBetterButton2.TabIndex = 4;
            notBetterButton2.Text = "Save";
            notBetterButton2.TextLocation_X = 76;
            notBetterButton2.TextLocation_Y = 24;
            notBetterButton2.Transparent1 = 150;
            notBetterButton2.Transparent2 = 150;
            notBetterButton2.UseVisualStyleBackColor = true;
            notBetterButton2.Visible = false;
            notBetterButton2.Click += notBetterButton2_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSave.Location = new System.Drawing.Point(832, 100);
            btnSave.Margin = new System.Windows.Forms.Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(79, 37);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblGuildAd
            // 
            lblGuildAd.AutoSize = true;
            lblGuildAd.Location = new System.Drawing.Point(26, 7);
            lblGuildAd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblGuildAd.Name = "lblGuildAd";
            lblGuildAd.Size = new System.Drawing.Size(0, 24);
            lblGuildAd.TabIndex = 3;
            // 
            // tbValue
            // 
            tbValue.BackColor = System.Drawing.SystemColors.Info;
            tbValue.Location = new System.Drawing.Point(31, 46);
            tbValue.Margin = new System.Windows.Forms.Padding(6);
            tbValue.Multiline = true;
            tbValue.Name = "tbValue";
            tbValue.Size = new System.Drawing.Size(363, 142);
            tbValue.TabIndex = 0;
            tbValue.TabStop = false;
            tbValue.Leave += tbValue_Leave;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1036, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 365);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1036, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // settingsMenuItem
            // 
            settingsMenuItem.Name = "settingsMenuItem";
            settingsMenuItem.Size = new System.Drawing.Size(180, 22);
            settingsMenuItem.Text = "Settings";
            settingsMenuItem.Click += settingsMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1036, 387);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(transparentFlowPanel1);
            Controls.Add(transparentPanel2);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(6);
            MaximizeBox = false;
            Name = "Main";
            Text = "Butler copy my...";
            Activated += Main_Activated;
            FormClosing += Form1_FormClosing;
            Load += Main_Load;
            Resize += Main_Resize;
            contextMenuStrip1.ResumeLayout(false);
            transparentFlowPanel1.ResumeLayout(false);
            transparentFlowPanel1.PerformLayout();
            transparentPanel2.ResumeLayout(false);
            transparentPanel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private JohnBPearson.Windows.Forms.Controls.NotBetterButton notBetterButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
    }
}

