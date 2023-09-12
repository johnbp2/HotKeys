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
            this.btnCopyGuildLog = new System.Windows.Forms.Button();
            this.transparentFlowPanel1 = new JohnBPearson.Windows.Forms.Controls.TransparentFlowPanel();
            this.lblHotkeyGuildAd = new System.Windows.Forms.Label();
            this.cbHotkeyGuildAd = new System.Windows.Forms.ComboBox();
            this.transparentFlowPanel2 = new JohnBPearson.Windows.Forms.Controls.TransparentFlowPanel();
            this.lblHotkeyAcceptance = new System.Windows.Forms.Label();
            this.cbHotkeyAcceptance = new System.Windows.Forms.ComboBox();
            this.transparentPanel2 = new JohnBPearson.Windows.Forms.Controls.TransparentPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGuildAd = new System.Windows.Forms.Label();
            this.lblAcceptance = new System.Windows.Forms.Label();
            this.tbAcceptance = new System.Windows.Forms.TextBox();
            this.tbGuildAd = new System.Windows.Forms.TextBox();
            this.transparentPanel1 = new JohnBPearson.Windows.Forms.Controls.TransparentPanel();
            this.lbPlanetsList = new System.Windows.Forms.ListBox();
            this.transparentFlowPanel1.SuspendLayout();
            this.transparentFlowPanel2.SuspendLayout();
            this.transparentPanel2.SuspendLayout();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Sneaky keys";
            this.notifyIcon1.BalloonTipTitle = "Uh-oh";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnCopyGuildLog
            // 
            this.btnCopyGuildLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyGuildLog.Location = new System.Drawing.Point(278, 127);
            this.btnCopyGuildLog.Name = "btnCopyGuildLog";
            this.btnCopyGuildLog.Size = new System.Drawing.Size(138, 23);
            this.btnCopyGuildLog.TabIndex = 5;
            this.btnCopyGuildLog.Text = "Copy log info to clipboard";
            this.btnCopyGuildLog.UseVisualStyleBackColor = true;
            this.btnCopyGuildLog.Visible = false;
            this.btnCopyGuildLog.Click += new System.EventHandler(this.btnCopyGuildLog_Click);
            // 
            // transparentFlowPanel1
            // 
            this.transparentFlowPanel1.Controls.Add(this.lblHotkeyGuildAd);
            this.transparentFlowPanel1.Controls.Add(this.cbHotkeyGuildAd);
            this.transparentFlowPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.transparentFlowPanel1.Location = new System.Drawing.Point(29, 79);
            this.transparentFlowPanel1.Name = "transparentFlowPanel1";
            this.transparentFlowPanel1.Size = new System.Drawing.Size(146, 42);
            this.transparentFlowPanel1.TabIndex = 2;
            // 
            // lblHotkeyGuildAd
            // 
            this.lblHotkeyGuildAd.AutoSize = true;
            this.lblHotkeyGuildAd.Location = new System.Drawing.Point(3, 0);
            this.lblHotkeyGuildAd.Name = "lblHotkeyGuildAd";
            this.lblHotkeyGuildAd.Size = new System.Drawing.Size(72, 13);
            this.lblHotkeyGuildAd.TabIndex = 0;
            this.lblHotkeyGuildAd.Text = "Alt +  Shift + s";
            // 
            // cbHotkeyGuildAd
            // 
            this.cbHotkeyGuildAd.FormattingEnabled = true;
            this.cbHotkeyGuildAd.Location = new System.Drawing.Point(3, 16);
            this.cbHotkeyGuildAd.Name = "cbHotkeyGuildAd";
            this.cbHotkeyGuildAd.Size = new System.Drawing.Size(121, 21);
            this.cbHotkeyGuildAd.TabIndex = 0;
            // 
            // transparentFlowPanel2
            // 
            this.transparentFlowPanel2.Controls.Add(this.lblHotkeyAcceptance);
            this.transparentFlowPanel2.Controls.Add(this.cbHotkeyAcceptance);
            this.transparentFlowPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.transparentFlowPanel2.Location = new System.Drawing.Point(263, 79);
            this.transparentFlowPanel2.Name = "transparentFlowPanel2";
            this.transparentFlowPanel2.Size = new System.Drawing.Size(144, 44);
            this.transparentFlowPanel2.TabIndex = 2;
            // 
            // lblHotkeyAcceptance
            // 
            this.lblHotkeyAcceptance.AutoSize = true;
            this.lblHotkeyAcceptance.Location = new System.Drawing.Point(3, 0);
            this.lblHotkeyAcceptance.Name = "lblHotkeyAcceptance";
            this.lblHotkeyAcceptance.Size = new System.Drawing.Size(72, 13);
            this.lblHotkeyAcceptance.TabIndex = 2;
            this.lblHotkeyAcceptance.Text = "Alt +  Shift + s";
            // 
            // cbHotkeyAcceptance
            // 
            this.cbHotkeyAcceptance.FormattingEnabled = true;
            this.cbHotkeyAcceptance.Location = new System.Drawing.Point(3, 16);
            this.cbHotkeyAcceptance.Name = "cbHotkeyAcceptance";
            this.cbHotkeyAcceptance.Size = new System.Drawing.Size(121, 21);
            this.cbHotkeyAcceptance.TabIndex = 1;
            // 
            // transparentPanel2
            // 
            this.transparentPanel2.Controls.Add(this.btnSave);
            this.transparentPanel2.Controls.Add(this.lblGuildAd);
            this.transparentPanel2.Controls.Add(this.lblAcceptance);
            this.transparentPanel2.Controls.Add(this.tbAcceptance);
            this.transparentPanel2.Controls.Add(this.tbGuildAd);
            this.transparentPanel2.Location = new System.Drawing.Point(12, 127);
            this.transparentPanel2.Name = "transparentPanel2";
            this.transparentPanel2.Size = new System.Drawing.Size(500, 129);
            this.transparentPanel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(454, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(43, 20);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGuildAd
            // 
            this.lblGuildAd.AutoSize = true;
            this.lblGuildAd.Location = new System.Drawing.Point(14, 4);
            this.lblGuildAd.Name = "lblGuildAd";
            this.lblGuildAd.Size = new System.Drawing.Size(48, 13);
            this.lblGuildAd.TabIndex = 3;
            this.lblGuildAd.Text = "hotkey 1";
            // 
            // lblAcceptance
            // 
            this.lblAcceptance.AutoSize = true;
            this.lblAcceptance.Location = new System.Drawing.Point(248, 4);
            this.lblAcceptance.Name = "lblAcceptance";
            this.lblAcceptance.Size = new System.Drawing.Size(48, 13);
            this.lblAcceptance.TabIndex = 2;
            this.lblAcceptance.Text = "hotkey 2";
            // 
            // tbAcceptance
            // 
            this.tbAcceptance.BackColor = System.Drawing.SystemColors.Info;
            this.tbAcceptance.Location = new System.Drawing.Point(248, 25);
            this.tbAcceptance.Multiline = true;
            this.tbAcceptance.Name = "tbAcceptance";
            this.tbAcceptance.Size = new System.Drawing.Size(200, 79);
            this.tbAcceptance.TabIndex = 1;
            this.tbAcceptance.TabStop = false;
            this.tbAcceptance.TextChanged += new System.EventHandler(this.tbAcceptance_TextChanged);
            // 
            // tbGuildAd
            // 
            this.tbGuildAd.BackColor = System.Drawing.SystemColors.Info;
            this.tbGuildAd.Location = new System.Drawing.Point(17, 25);
            this.tbGuildAd.Multiline = true;
            this.tbGuildAd.Name = "tbGuildAd";
            this.tbGuildAd.Size = new System.Drawing.Size(200, 79);
            this.tbGuildAd.TabIndex = 0;
            this.tbGuildAd.TabStop = false;
            this.tbGuildAd.TextChanged += new System.EventHandler(this.tbGuildAd_TextChanged);
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.lbPlanetsList);
            this.transparentPanel1.Controls.Add(this.btnCopyGuildLog);
            this.transparentPanel1.Location = new System.Drawing.Point(55, 283);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(419, 155);
            this.transparentPanel1.TabIndex = 7;
            // 
            // lbPlanetsList
            // 
            this.lbPlanetsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPlanetsList.FormattingEnabled = true;
            this.lbPlanetsList.Location = new System.Drawing.Point(0, 0);
            this.lbPlanetsList.Name = "lbPlanetsList";
            this.lbPlanetsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPlanetsList.Size = new System.Drawing.Size(419, 121);
            this.lbPlanetsList.TabIndex = 6;
            this.lbPlanetsList.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 462);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.transparentFlowPanel1);
            this.Controls.Add(this.transparentFlowPanel2);
            this.Controls.Add(this.transparentPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Butler copy my...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.transparentFlowPanel1.ResumeLayout(false);
            this.transparentFlowPanel1.PerformLayout();
            this.transparentFlowPanel2.ResumeLayout(false);
            this.transparentFlowPanel2.PerformLayout();
            this.transparentPanel2.ResumeLayout(false);
            this.transparentPanel2.PerformLayout();
            this.transparentPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private JohnBPearson.Windows.Forms.Controls.TransparentPanel transparentPanel2;
        private System.Windows.Forms.TextBox tbGuildAd;
        private System.Windows.Forms.Label lblGuildAd;
        private System.Windows.Forms.Label lblAcceptance;
        private System.Windows.Forms.TextBox tbAcceptance;
        private System.Windows.Forms.Button btnSave;
        private JohnBPearson.Windows.Forms.Controls.TransparentFlowPanel transparentFlowPanel1;
        private System.Windows.Forms.Label lblHotkeyGuildAd;
        private System.Windows.Forms.ComboBox cbHotkeyGuildAd;
        private Controls.TransparentFlowPanel transparentFlowPanel2;
        private System.Windows.Forms.Label lblHotkeyAcceptance;
        private System.Windows.Forms.ComboBox cbHotkeyAcceptance;
        private System.Windows.Forms.Button btnCopyGuildLog;
        private Controls.TransparentPanel transparentPanel1;
        private System.Windows.Forms.ListBox lbPlanetsList;
    }
}

