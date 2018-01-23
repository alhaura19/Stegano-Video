namespace StegoVideo.View
{
    partial class CompareForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuCompare = new MetroFramework.Controls.MetroButton();
            this.MenuExtract = new MetroFramework.Controls.MetroButton();
            this.MenuHide = new MetroFramework.Controls.MetroButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProcessBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VideoTextPath = new MetroFramework.Controls.MetroTextBox();
            this.BrowseBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VideoTextPath2 = new MetroFramework.Controls.MetroTextBox();
            this.BrowseBtn2 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.processBtn2 = new MetroFramework.Controls.MetroButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnText1 = new MetroFramework.Controls.MetroButton();
            this.btnText2 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(115, 486);
            this.panel1.TabIndex = 11;
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
            this.MenuCompare.TabIndex = 11;
            this.MenuCompare.Text = "Compare";
            this.MenuCompare.UseCustomBackColor = true;
            this.MenuCompare.UseCustomForeColor = true;
            this.MenuCompare.UseSelectable = true;
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
            this.MenuHide.Click += new System.EventHandler(this.MenuHide_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(112, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 490);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProcessBtn);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compare Video";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ProcessBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ProcessBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ProcessBtn.Location = new System.Drawing.Point(345, 429);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(97, 29);
            this.ProcessBtn.TabIndex = 33;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseCustomBackColor = true;
            this.ProcessBtn.UseCustomForeColor = true;
            this.ProcessBtn.UseSelectable = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.VideoTextPath);
            this.groupBox1.Controls.Add(this.BrowseBtn);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 345);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(7, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 259);
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
            this.VideoTextPath.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.VideoTextPath.CustomButton.Name = "";
            this.VideoTextPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VideoTextPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VideoTextPath.CustomButton.TabIndex = 1;
            this.VideoTextPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VideoTextPath.CustomButton.UseSelectable = true;
            this.VideoTextPath.CustomButton.Visible = false;
            this.VideoTextPath.Enabled = false;
            this.VideoTextPath.Lines = new string[0];
            this.VideoTextPath.Location = new System.Drawing.Point(7, 283);
            this.VideoTextPath.MaxLength = 32767;
            this.VideoTextPath.Name = "VideoTextPath";
            this.VideoTextPath.PasswordChar = '\0';
            this.VideoTextPath.PromptText = "Browse AVI video";
            this.VideoTextPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VideoTextPath.SelectedText = "";
            this.VideoTextPath.SelectionLength = 0;
            this.VideoTextPath.SelectionStart = 0;
            this.VideoTextPath.ShortcutsEnabled = true;
            this.VideoTextPath.Size = new System.Drawing.Size(363, 23);
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
            this.BrowseBtn.Location = new System.Drawing.Point(282, 312);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(97, 28);
            this.BrowseBtn.TabIndex = 12;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseCustomBackColor = true;
            this.BrowseBtn.UseCustomForeColor = true;
            this.BrowseBtn.UseSelectable = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.VideoTextPath2);
            this.groupBox2.Controls.Add(this.BrowseBtn2);
            this.groupBox2.Location = new System.Drawing.Point(398, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 345);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(7, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(363, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // VideoTextPath2
            // 
            // 
            // 
            // 
            this.VideoTextPath2.CustomButton.Image = null;
            this.VideoTextPath2.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.VideoTextPath2.CustomButton.Name = "";
            this.VideoTextPath2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VideoTextPath2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VideoTextPath2.CustomButton.TabIndex = 1;
            this.VideoTextPath2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VideoTextPath2.CustomButton.UseSelectable = true;
            this.VideoTextPath2.CustomButton.Visible = false;
            this.VideoTextPath2.Enabled = false;
            this.VideoTextPath2.Lines = new string[0];
            this.VideoTextPath2.Location = new System.Drawing.Point(9, 283);
            this.VideoTextPath2.MaxLength = 32767;
            this.VideoTextPath2.Name = "VideoTextPath2";
            this.VideoTextPath2.PasswordChar = '\0';
            this.VideoTextPath2.PromptText = "Browse AVI Video";
            this.VideoTextPath2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VideoTextPath2.SelectedText = "";
            this.VideoTextPath2.SelectionLength = 0;
            this.VideoTextPath2.SelectionStart = 0;
            this.VideoTextPath2.ShortcutsEnabled = true;
            this.VideoTextPath2.Size = new System.Drawing.Size(367, 23);
            this.VideoTextPath2.TabIndex = 10;
            this.VideoTextPath2.UseSelectable = true;
            this.VideoTextPath2.WaterMark = "Browse AVI Video";
            this.VideoTextPath2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VideoTextPath2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BrowseBtn2
            // 
            this.BrowseBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BrowseBtn2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BrowseBtn2.ForeColor = System.Drawing.SystemColors.Control;
            this.BrowseBtn2.Location = new System.Drawing.Point(276, 312);
            this.BrowseBtn2.Name = "BrowseBtn2";
            this.BrowseBtn2.Size = new System.Drawing.Size(97, 28);
            this.BrowseBtn2.TabIndex = 16;
            this.BrowseBtn2.Text = "Browse";
            this.BrowseBtn2.UseCustomBackColor = true;
            this.BrowseBtn2.UseCustomForeColor = true;
            this.BrowseBtn2.UseSelectable = true;
            this.BrowseBtn2.Click += new System.EventHandler(this.BrowseBtn2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(4, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 65);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MSE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "SSIM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "PSNR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size video 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size video 1:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.processBtn2);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare Text";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // processBtn2
            // 
            this.processBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.processBtn2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.processBtn2.ForeColor = System.Drawing.SystemColors.Control;
            this.processBtn2.Location = new System.Drawing.Point(346, 413);
            this.processBtn2.Name = "processBtn2";
            this.processBtn2.Size = new System.Drawing.Size(97, 29);
            this.processBtn2.TabIndex = 34;
            this.processBtn2.Text = "Process";
            this.processBtn2.UseCustomBackColor = true;
            this.processBtn2.UseCustomForeColor = true;
            this.processBtn2.UseSelectable = true;
            this.processBtn2.Click += new System.EventHandler(this.processBtn2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(396, 333);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(377, 59);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(131, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Jumlah karakter error:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(6, 333);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(384, 59);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Akurasi teks:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 32);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnText2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(396, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(377, 321);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Text 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = ".";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(365, 269);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnText1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 321);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = ".";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(365, 269);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnText1
            // 
            this.btnText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnText1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnText1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnText1.Location = new System.Drawing.Point(274, 291);
            this.btnText1.Name = "btnText1";
            this.btnText1.Size = new System.Drawing.Size(97, 29);
            this.btnText1.TabIndex = 35;
            this.btnText1.Text = "Browse Text";
            this.btnText1.UseCustomBackColor = true;
            this.btnText1.UseCustomForeColor = true;
            this.btnText1.UseSelectable = true;
            this.btnText1.Click += new System.EventHandler(this.btnText1_Click);
            // 
            // btnText2
            // 
            this.btnText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnText2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnText2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnText2.Location = new System.Drawing.Point(274, 291);
            this.btnText2.Name = "btnText2";
            this.btnText2.Size = new System.Drawing.Size(97, 29);
            this.btnText2.TabIndex = 36;
            this.btnText2.Text = "Browse Text";
            this.btnText2.UseCustomBackColor = true;
            this.btnText2.UseCustomForeColor = true;
            this.btnText2.UseSelectable = true;
            this.btnText2.Click += new System.EventHandler(this.btnText2_Click);
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "CompareForm";
            this.Text = "COMPARE FORM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompareForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton MenuExtract;
        private MetroFramework.Controls.MetroButton MenuHide;
        private MetroFramework.Controls.MetroButton MenuCompare;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroButton ProcessBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox VideoTextPath;
        private MetroFramework.Controls.MetroButton BrowseBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox VideoTextPath2;
        private MetroFramework.Controls.MetroButton BrowseBtn2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroButton processBtn2;
        private MetroFramework.Controls.MetroButton btnText2;
        private MetroFramework.Controls.MetroButton btnText1;
    }
}