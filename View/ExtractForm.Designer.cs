namespace StegoVideo.View
{
    partial class ExtractForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VideoTextPath = new MetroFramework.Controls.MetroTextBox();
            this.BrowseBtn = new MetroFramework.Controls.MetroButton();
            this.SecretTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDecrypt = new MetroFramework.Controls.MetroButton();
            this.TextCount = new MetroFramework.Controls.MetroLabel();
            this.ExtractBtn = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuExtract = new MetroFramework.Controls.MetroButton();
            this.MenuHide = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuCompare = new MetroFramework.Controls.MetroButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI(*.avi)|*.avi";
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(150, 26);
            this.status.Text = "Current tatus";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(3, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 31);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VideoTextPath
            // 
            this.VideoTextPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.VideoTextPath.CustomButton.Image = null;
            this.VideoTextPath.CustomButton.Location = new System.Drawing.Point(271, 2);
            this.VideoTextPath.CustomButton.Name = "";
            this.VideoTextPath.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.VideoTextPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VideoTextPath.CustomButton.TabIndex = 1;
            this.VideoTextPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VideoTextPath.CustomButton.UseSelectable = true;
            this.VideoTextPath.CustomButton.Visible = false;
            this.VideoTextPath.Enabled = false;
            this.VideoTextPath.Lines = new string[0];
            this.VideoTextPath.Location = new System.Drawing.Point(6, 323);
            this.VideoTextPath.MaxLength = 32767;
            this.VideoTextPath.Name = "VideoTextPath";
            this.VideoTextPath.PasswordChar = '\0';
            this.VideoTextPath.PromptText = "Browse AVI video";
            this.VideoTextPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VideoTextPath.SelectedText = "";
            this.VideoTextPath.SelectionLength = 0;
            this.VideoTextPath.SelectionStart = 0;
            this.VideoTextPath.ShortcutsEnabled = true;
            this.VideoTextPath.Size = new System.Drawing.Size(386, 23);
            this.VideoTextPath.TabIndex = 1;
            this.VideoTextPath.UseSelectable = true;
            this.VideoTextPath.WaterMark = "Browse AVI video";
            this.VideoTextPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VideoTextPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BrowseBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BrowseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BrowseBtn.Location = new System.Drawing.Point(295, 357);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(97, 28);
            this.BrowseBtn.TabIndex = 12;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseCustomBackColor = true;
            this.BrowseBtn.UseCustomForeColor = true;
            this.BrowseBtn.UseSelectable = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click_1);
            // 
            // SecretTextBox
            // 
            // 
            // 
            // 
            this.SecretTextBox.CustomButton.Image = null;
            this.SecretTextBox.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.SecretTextBox.CustomButton.Name = "";
            this.SecretTextBox.CustomButton.Size = new System.Drawing.Size(315, 315);
            this.SecretTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SecretTextBox.CustomButton.TabIndex = 1;
            this.SecretTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SecretTextBox.CustomButton.UseSelectable = true;
            this.SecretTextBox.CustomButton.Visible = false;
            this.SecretTextBox.Lines = new string[0];
            this.SecretTextBox.Location = new System.Drawing.Point(6, 19);
            this.SecretTextBox.MaxLength = 32767;
            this.SecretTextBox.Multiline = true;
            this.SecretTextBox.Name = "SecretTextBox";
            this.SecretTextBox.PasswordChar = '\0';
            this.SecretTextBox.PromptText = "secret messages";
            this.SecretTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SecretTextBox.SelectedText = "";
            this.SecretTextBox.SelectionLength = 0;
            this.SecretTextBox.SelectionStart = 0;
            this.SecretTextBox.ShortcutsEnabled = true;
            this.SecretTextBox.Size = new System.Drawing.Size(359, 279);
            this.SecretTextBox.TabIndex = 3;
            this.SecretTextBox.UseSelectable = true;
            this.SecretTextBox.WaterMark = "secret messages";
            this.SecretTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SecretTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SecretTextBox.TextChanged += new System.EventHandler(this.SecretTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.VideoTextPath);
            this.groupBox1.Controls.Add(this.BrowseBtn);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 436);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video";
            // 
            // PassTextBox
            // 
            // 
            // 
            // 
            this.PassTextBox.CustomButton.Image = null;
            this.PassTextBox.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.PassTextBox.CustomButton.Name = "";
            this.PassTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassTextBox.CustomButton.TabIndex = 1;
            this.PassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassTextBox.CustomButton.UseSelectable = true;
            this.PassTextBox.CustomButton.Visible = false;
            this.PassTextBox.Lines = new string[0];
            this.PassTextBox.Location = new System.Drawing.Point(6, 323);
            this.PassTextBox.MaxLength = 32767;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.PromptText = "Type password here";
            this.PassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassTextBox.SelectedText = "";
            this.PassTextBox.SelectionLength = 0;
            this.PassTextBox.SelectionStart = 0;
            this.PassTextBox.ShortcutsEnabled = true;
            this.PassTextBox.Size = new System.Drawing.Size(359, 23);
            this.PassTextBox.TabIndex = 10;
            this.PassTextBox.UseSelectable = true;
            this.PassTextBox.WaterMark = "Type password here";
            this.PassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDecrypt);
            this.groupBox2.Controls.Add(this.TextCount);
            this.groupBox2.Controls.Add(this.ExtractBtn);
            this.groupBox2.Controls.Add(this.SecretTextBox);
            this.groupBox2.Controls.Add(this.PassTextBox);
            this.groupBox2.Location = new System.Drawing.Point(409, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 436);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnDecrypt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDecrypt.Location = new System.Drawing.Point(268, 357);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(97, 28);
            this.btnDecrypt.TabIndex = 18;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseCustomBackColor = true;
            this.btnDecrypt.UseCustomForeColor = true;
            this.btnDecrypt.UseSelectable = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // TextCount
            // 
            this.TextCount.AutoSize = true;
            this.TextCount.Location = new System.Drawing.Point(6, 301);
            this.TextCount.Name = "TextCount";
            this.TextCount.Size = new System.Drawing.Size(12, 19);
            this.TextCount.TabIndex = 17;
            this.TextCount.Text = ".";
            // 
            // ExtractBtn
            // 
            this.ExtractBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ExtractBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ExtractBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ExtractBtn.Location = new System.Drawing.Point(165, 357);
            this.ExtractBtn.Name = "ExtractBtn";
            this.ExtractBtn.Size = new System.Drawing.Size(97, 28);
            this.ExtractBtn.TabIndex = 15;
            this.ExtractBtn.Text = "Extract";
            this.ExtractBtn.UseCustomBackColor = true;
            this.ExtractBtn.UseCustomForeColor = true;
            this.ExtractBtn.UseSelectable = true;
            this.ExtractBtn.Click += new System.EventHandler(this.ExtractBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(115, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 451);
            this.panel2.TabIndex = 14;
            // 
            // MenuExtract
            // 
            this.MenuExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.MenuExtract.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MenuExtract.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.MenuExtract.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExtract.Location = new System.Drawing.Point(0, 58);
            this.MenuExtract.Name = "MenuExtract";
            this.MenuExtract.Size = new System.Drawing.Size(115, 58);
            this.MenuExtract.TabIndex = 10;
            this.MenuExtract.Text = "Extract";
            this.MenuExtract.UseCustomBackColor = true;
            this.MenuExtract.UseCustomForeColor = true;
            this.MenuExtract.UseSelectable = true;
            // 
            // MenuHide
            // 
            this.MenuHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.MenuHide.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MenuHide.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.MenuHide.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuHide.Location = new System.Drawing.Point(0, 0);
            this.MenuHide.Name = "MenuHide";
            this.MenuHide.Size = new System.Drawing.Size(115, 58);
            this.MenuHide.TabIndex = 9;
            this.MenuHide.Text = "Embed";
            this.MenuHide.UseCustomBackColor = true;
            this.MenuHide.UseCustomForeColor = true;
            this.MenuHide.UseSelectable = true;
            this.MenuHide.Click += new System.EventHandler(this.MenuHide_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.MenuCompare);
            this.panel1.Controls.Add(this.MenuExtract);
            this.panel1.Controls.Add(this.MenuHide);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 451);
            this.panel1.TabIndex = 13;
            // 
            // MenuCompare
            // 
            this.MenuCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.MenuCompare.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MenuCompare.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.MenuCompare.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuCompare.Location = new System.Drawing.Point(0, 116);
            this.MenuCompare.Name = "MenuCompare";
            this.MenuCompare.Size = new System.Drawing.Size(115, 58);
            this.MenuCompare.TabIndex = 12;
            this.MenuCompare.Text = "Compare";
            this.MenuCompare.UseCustomBackColor = true;
            this.MenuCompare.UseCustomForeColor = true;
            this.MenuCompare.UseSelectable = true;
            this.MenuCompare.Click += new System.EventHandler(this.MenuCompare_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(150, 520);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(650, 23);
            this.progressBar.TabIndex = 20;
            // 
            // ExtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ExtractForm";
            this.Text = "EXTRACT FORM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtractForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton MenuExtract;
        private MetroFramework.Controls.MetroButton MenuHide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox SecretTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox VideoTextPath;
        private MetroFramework.Controls.MetroButton BrowseBtn;
        private MetroFramework.Controls.MetroTextBox PassTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private MetroFramework.Controls.MetroButton MenuCompare;
        private MetroFramework.Controls.MetroButton ExtractBtn;
        private MetroFramework.Controls.MetroLabel TextCount;
        private MetroFramework.Controls.MetroButton btnDecrypt;
    }
}