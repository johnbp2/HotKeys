using JohnBPearson.Windows.Forms.Controls;

namespace JohnBPearson.Windows.Forms.KeyBindingButler
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            transparentFlowPanel1 = new TransparentFlowPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            rbAutoSaveOn = new AdvancedRadioButton();
            rbAutoSaveOff = new AdvancedRadioButton();
            lblMinimizeToTray = new System.Windows.Forms.Label();
            rbMinimizeToTrayOn = new AdvancedRadioButton();
            rbMinimizeToTrayOff = new AdvancedRadioButton();
            tbServantName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            transparentPanel1 = new TransparentPanel();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            popupNotifier1 = new Tulpep.NotificationWindow.PopupNotifier();
            transparentFlowPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // transparentFlowPanel1
            // 
            transparentFlowPanel1.Controls.Add(tableLayoutPanel1);
            transparentFlowPanel1.Controls.Add(transparentPanel1);
            transparentFlowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            transparentFlowPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            transparentFlowPanel1.Location = new System.Drawing.Point(0, 0);
            transparentFlowPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            transparentFlowPanel1.Name = "transparentFlowPanel1";
            transparentFlowPanel1.Size = new System.Drawing.Size(309, 313);
            transparentFlowPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(rbAutoSaveOn, 1, 0);
            tableLayoutPanel1.Controls.Add(rbAutoSaveOff, 2, 0);
            tableLayoutPanel1.Controls.Add(lblMinimizeToTray, 0, 1);
            tableLayoutPanel1.Controls.Add(rbMinimizeToTrayOn, 1, 1);
            tableLayoutPanel1.Controls.Add(rbMinimizeToTrayOff, 2, 1);
            tableLayoutPanel1.Controls.Add(tbServantName, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new System.Drawing.Size(301, 253);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 7);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "auto save";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbAutoSaveOn
            // 
            rbAutoSaveOn.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rbAutoSaveOn.AutoSize = true;
            rbAutoSaveOn.GroupName = "autosave";
            rbAutoSaveOn.GroupNameLevel = AdvancedRadioButton.Level.Form;
            rbAutoSaveOn.Location = new System.Drawing.Point(106, 5);
            rbAutoSaveOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbAutoSaveOn.Name = "rbAutoSaveOn";
            rbAutoSaveOn.Size = new System.Drawing.Size(91, 19);
            rbAutoSaveOn.TabIndex = 3;
            rbAutoSaveOn.Text = "on";
            rbAutoSaveOn.UseVisualStyleBackColor = true;
            // 
            // rbAutoSaveOff
            // 
            rbAutoSaveOff.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rbAutoSaveOff.AutoSize = true;
            rbAutoSaveOff.GroupName = "autosave";
            rbAutoSaveOff.GroupNameLevel = AdvancedRadioButton.Level.Form;
            rbAutoSaveOff.Location = new System.Drawing.Point(205, 5);
            rbAutoSaveOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbAutoSaveOff.Name = "rbAutoSaveOff";
            rbAutoSaveOff.Size = new System.Drawing.Size(92, 19);
            rbAutoSaveOff.TabIndex = 4;
            rbAutoSaveOff.Text = "off";
            rbAutoSaveOff.UseVisualStyleBackColor = true;
            // 
            // lblMinimizeToTray
            // 
            lblMinimizeToTray.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMinimizeToTray.AutoSize = true;
            lblMinimizeToTray.Location = new System.Drawing.Point(4, 32);
            lblMinimizeToTray.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMinimizeToTray.Name = "lblMinimizeToTray";
            lblMinimizeToTray.Size = new System.Drawing.Size(94, 15);
            lblMinimizeToTray.TabIndex = 5;
            lblMinimizeToTray.Text = "minimize to tray";
            lblMinimizeToTray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbMinimizeToTrayOn
            // 
            rbMinimizeToTrayOn.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rbMinimizeToTrayOn.AutoSize = true;
            rbMinimizeToTrayOn.GroupName = "minimize";
            rbMinimizeToTrayOn.GroupNameLevel = AdvancedRadioButton.Level.Form;
            rbMinimizeToTrayOn.Location = new System.Drawing.Point(106, 32);
            rbMinimizeToTrayOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbMinimizeToTrayOn.Name = "rbMinimizeToTrayOn";
            rbMinimizeToTrayOn.Size = new System.Drawing.Size(91, 16);
            rbMinimizeToTrayOn.TabIndex = 6;
            rbMinimizeToTrayOn.Text = "on";
            rbMinimizeToTrayOn.UseVisualStyleBackColor = true;
            // 
            // rbMinimizeToTrayOff
            // 
            rbMinimizeToTrayOff.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rbMinimizeToTrayOff.AutoSize = true;
            rbMinimizeToTrayOff.GroupName = "111";
            rbMinimizeToTrayOff.GroupNameLevel = AdvancedRadioButton.Level.Form;
            rbMinimizeToTrayOff.Location = new System.Drawing.Point(205, 32);
            rbMinimizeToTrayOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbMinimizeToTrayOff.Name = "rbMinimizeToTrayOff";
            rbMinimizeToTrayOff.Size = new System.Drawing.Size(92, 16);
            rbMinimizeToTrayOff.TabIndex = 7;
            rbMinimizeToTrayOff.Text = "off";
            rbMinimizeToTrayOff.UseVisualStyleBackColor = true;
            // 
            // tbServantName
            // 
            tableLayoutPanel1.SetColumnSpan(tbServantName, 2);
            tbServantName.Location = new System.Drawing.Point(106, 54);
            tbServantName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbServantName.Name = "tbServantName";
            tbServantName.Size = new System.Drawing.Size(191, 23);
            tbServantName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1, 52);
            label2.Margin = new System.Windows.Forms.Padding(1);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 30);
            label2.TabIndex = 9;
            label2.Text = "Name your man servant";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transparentPanel1
            // 
            transparentPanel1.Controls.Add(btnSave);
            transparentPanel1.Controls.Add(btnCancel);
            transparentPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            transparentPanel1.Location = new System.Drawing.Point(4, 262);
            transparentPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            transparentPanel1.Name = "transparentPanel1";
            transparentPanel1.Size = new System.Drawing.Size(301, 38);
            transparentPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(204, 3);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 3;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(108, 3);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // popupNotifier1
            // 
            popupNotifier1.AnimationDuration = 2000;
            popupNotifier1.AnimationInterval = 200;
            popupNotifier1.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popupNotifier1.ContentHoverColor = System.Drawing.SystemColors.Highlight;
            popupNotifier1.ContentText = null;
            popupNotifier1.Image = (System.Drawing.Image)resources.GetObject("popupNotifier1.Image");
            popupNotifier1.IsRightToLeft = false;
            popupNotifier1.OptionsMenu = null;
            popupNotifier1.Size = new System.Drawing.Size(400, 100);
            popupNotifier1.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            popupNotifier1.TitleText = null;
            popupNotifier1.Appear += popupNotifier1_Appear;
            popupNotifier1.Disappear += popupNotifier1_Disappear;
            // 
            // SettingsDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(309, 313);
            Controls.Add(transparentFlowPanel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SettingsDialog";
            Text = "Settings";
            Load += SettingsDialog_Load;
            transparentFlowPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            transparentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.TransparentFlowPanel transparentFlowPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private Controls.AdvancedRadioButton rbAutoSaveOn;
        private Controls.AdvancedRadioButton rbAutoSaveOff;
        private System.Windows.Forms.Label lblMinimizeToTray;
        private Controls.AdvancedRadioButton rbMinimizeToTrayOn;
        private Controls.AdvancedRadioButton rbMinimizeToTrayOff;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier1;
        private System.Windows.Forms.TextBox tbServantName;
        private System.Windows.Forms.Label label2;
    }
}