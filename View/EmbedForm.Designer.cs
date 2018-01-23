namespace StegoVideo.View
{
    partial class EmbedForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuCompare = new MetroFramework.Controls.MetroButton();
            this.MenuExtract = new MetroFramework.Controls.MetroButton();
            this.MenuHide = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textCount1 = new MetroFramework.Controls.MetroLabel();
            this.encryptedTextBox = new MetroFramework.Controls.MetroTextBox();
            this.BtnEncrypt = new MetroFramework.Controls.MetroButton();
            this.textBox = new MetroFramework.Controls.MetroTextBox();
            this.textCount2 = new MetroFramework.Controls.MetroLabel();
            this.EmbedBtn = new MetroFramework.Controls.MetroButton();
            this.PassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VideoTextPath = new MetroFramework.Controls.MetroTextBox();
            this.BrowseBtn = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnFile = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 10;
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
            this.MenuExtract.Click += new System.EventHandler(this.MenuExtract_Click);
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
            this.MenuHide.Text = "Hide";
            this.MenuHide.UseCustomBackColor = true;
            this.MenuHide.UseCustomForeColor = true;
            this.MenuHide.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(115, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 451);
            this.panel2.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFile);
            this.groupBox2.Controls.Add(this.textCount1);
            this.groupBox2.Controls.Add(this.encryptedTextBox);
            this.groupBox2.Controls.Add(this.BtnEncrypt);
            this.groupBox2.Controls.Add(this.textBox);
            this.groupBox2.Controls.Add(this.textCount2);
            this.groupBox2.Controls.Add(this.EmbedBtn);
            this.groupBox2.Controls.Add(this.PassTextBox);
            this.groupBox2.Location = new System.Drawing.Point(409, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 436);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text";
            // 
            // textCount1
            // 
            this.textCount1.AutoSize = true;
            this.textCount1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.textCount1.Location = new System.Drawing.Point(6, 182);
            this.textCount1.Name = "textCount1";
            this.textCount1.Size = new System.Drawing.Size(10, 15);
            this.textCount1.TabIndex = 22;
            this.textCount1.Text = ".";
            // 
            // encryptedTextBox
            // 
            // 
            // 
            // 
            this.encryptedTextBox.CustomButton.Image = null;
            this.encryptedTextBox.CustomButton.Location = new System.Drawing.Point(209, 2);
            this.encryptedTextBox.CustomButton.Name = "";
            this.encryptedTextBox.CustomButton.Size = new System.Drawing.Size(147, 147);
            this.encryptedTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.encryptedTextBox.CustomButton.TabIndex = 1;
            this.encryptedTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.encryptedTextBox.CustomButton.UseSelectable = true;
            this.encryptedTextBox.CustomButton.Visible = false;
            this.encryptedTextBox.Lines = new string[0];
            this.encryptedTextBox.Location = new System.Drawing.Point(6, 245);
            this.encryptedTextBox.MaxLength = 32767;
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.PasswordChar = '\0';
            this.encryptedTextBox.PromptText = "Encrypted message";
            this.encryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptedTextBox.SelectedText = "";
            this.encryptedTextBox.SelectionLength = 0;
            this.encryptedTextBox.SelectionStart = 0;
            this.encryptedTextBox.ShortcutsEnabled = true;
            this.encryptedTextBox.Size = new System.Drawing.Size(359, 152);
            this.encryptedTextBox.TabIndex = 21;
            this.encryptedTextBox.UseSelectable = true;
            this.encryptedTextBox.WaterMark = "Encrypted message";
            this.encryptedTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.encryptedTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.encryptedTextBox.TextChanged += new System.EventHandler(this.encryptedTextBox_TextChanged);
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnEncrypt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnEncrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEncrypt.Location = new System.Drawing.Point(165, 405);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(97, 28);
            this.BtnEncrypt.TabIndex = 18;
            this.BtnEncrypt.Text = "Encrypt Text";
            this.BtnEncrypt.UseCustomBackColor = true;
            this.BtnEncrypt.UseCustomForeColor = true;
            this.BtnEncrypt.UseSelectable = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // textBox
            // 
            // 
            // 
            // 
            this.textBox.CustomButton.Image = null;
            this.textBox.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.textBox.CustomButton.Name = "";
            this.textBox.CustomButton.Size = new System.Drawing.Size(155, 155);
            this.textBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox.CustomButton.TabIndex = 1;
            this.textBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox.CustomButton.UseSelectable = true;
            this.textBox.CustomButton.Visible = false;
            this.textBox.Lines = new string[0];
            this.textBox.Location = new System.Drawing.Point(6, 19);
            this.textBox.MaxLength = 32767;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.PromptText = "Type secret message";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.SelectedText = "";
            this.textBox.SelectionLength = 0;
            this.textBox.SelectionStart = 0;
            this.textBox.ShortcutsEnabled = true;
            this.textBox.Size = new System.Drawing.Size(359, 157);
            this.textBox.TabIndex = 3;
            this.textBox.UseSelectable = true;
            this.textBox.WaterMark = "Type secret message";
            this.textBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox.TextChanged += new System.EventHandler(this.SecretTextBox_TextChanged);
            // 
            // textCount2
            // 
            this.textCount2.AutoSize = true;
            this.textCount2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.textCount2.Location = new System.Drawing.Point(6, 402);
            this.textCount2.Name = "textCount2";
            this.textCount2.Size = new System.Drawing.Size(10, 15);
            this.textCount2.TabIndex = 8;
            this.textCount2.Text = ".";
            // 
            // EmbedBtn
            // 
            this.EmbedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.EmbedBtn.Enabled = false;
            this.EmbedBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.EmbedBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.EmbedBtn.Location = new System.Drawing.Point(268, 405);
            this.EmbedBtn.Name = "EmbedBtn";
            this.EmbedBtn.Size = new System.Drawing.Size(97, 28);
            this.EmbedBtn.TabIndex = 14;
            this.EmbedBtn.Text = "Embed";
            this.EmbedBtn.UseCustomBackColor = true;
            this.EmbedBtn.UseCustomForeColor = true;
            this.EmbedBtn.UseSelectable = true;
            this.EmbedBtn.Click += new System.EventHandler(this.EmbedBtn_Click);
            // 
            // PassTextBox
            // 
            // 
            // 
            // 
            this.PassTextBox.CustomButton.Image = null;
            this.PassTextBox.CustomButton.Location = new System.Drawing.Point(337, 1);
            this.PassTextBox.CustomButton.Name = "";
            this.PassTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassTextBox.CustomButton.TabIndex = 1;
            this.PassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassTextBox.CustomButton.UseSelectable = true;
            this.PassTextBox.CustomButton.Visible = false;
            this.PassTextBox.Lines = new string[0];
            this.PassTextBox.Location = new System.Drawing.Point(6, 216);
            this.PassTextBox.MaxLength = 32767;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.PromptText = "Type password (max. 8 characters)";
            this.PassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassTextBox.SelectedText = "";
            this.PassTextBox.SelectionLength = 0;
            this.PassTextBox.SelectionStart = 0;
            this.PassTextBox.ShortcutsEnabled = true;
            this.PassTextBox.Size = new System.Drawing.Size(359, 23);
            this.PassTextBox.TabIndex = 10;
            this.PassTextBox.UseSelectable = true;
            this.PassTextBox.WaterMark = "Type password (max. 8 characters)";
            this.PassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Frame:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Size: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Frame Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Width:";
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
            this.VideoTextPath.CustomButton.Location = new System.Drawing.Point(364, 1);
            this.VideoTextPath.CustomButton.Name = "";
            this.VideoTextPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VideoTextPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VideoTextPath.CustomButton.TabIndex = 1;
            this.VideoTextPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VideoTextPath.CustomButton.UseSelectable = true;
            this.VideoTextPath.CustomButton.Visible = false;
            this.VideoTextPath.Enabled = false;
            this.VideoTextPath.Lines = new string[0];
            this.VideoTextPath.Location = new System.Drawing.Point(6, 304);
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
            this.BrowseBtn.Location = new System.Drawing.Point(295, 333);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(97, 28);
            this.BrowseBtn.TabIndex = 12;
            this.BrowseBtn.Text = "Browse Video";
            this.BrowseBtn.UseCustomBackColor = true;
            this.BrowseBtn.UseCustomForeColor = true;
            this.BrowseBtn.UseSelectable = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
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
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(150, 26);
            this.status.Text = "Current tatus";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI(*.avi)|*.avi";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(150, 520);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(650, 23);
            this.progressBar.TabIndex = 19;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFile.Location = new System.Drawing.Point(268, 182);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(97, 28);
            this.btnFile.TabIndex = 23;
            this.btnFile.Text = "Browse Text";
            this.btnFile.UseCustomBackColor = true;
            this.btnFile.UseCustomForeColor = true;
            this.btnFile.UseSelectable = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // EmbedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "EmbedForm";
            this.Text = "EMBED FORM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmbedForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnExtract;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox VideoTextPath;
        private MetroFramework.Controls.MetroButton BrowseBtn;
        private MetroFramework.Controls.MetroTextBox textBox;
        private MetroFramework.Controls.MetroLabel textCount2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton EmbedBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox PassTextBox;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton MenuExtract;
        private MetroFramework.Controls.MetroButton MenuHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroButton BtnEncrypt;
        private MetroFramework.Controls.MetroButton MenuCompare;
        private MetroFramework.Controls.MetroTextBox encryptedTextBox;
        private MetroFramework.Controls.MetroLabel textCount1;
        private MetroFramework.Controls.MetroButton btnFile;
    }
}