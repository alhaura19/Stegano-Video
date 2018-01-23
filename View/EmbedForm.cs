using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using StegoVideo.Controller;

namespace StegoVideo.View
{
    public partial class EmbedForm : MetroForm
    {
        VideoController videoController;
        FrameProcessing frameProcessing;
        string fileVideo, fileText;
        string encryptedText;
        string secretText;
        string[] infoVideo;
        Bitmap oriFrame = null;
        Bitmap stegoFrame = null;

        public EmbedForm()
        {
            InitializeComponent();
            videoController = new VideoController();
            frameProcessing = new FrameProcessing();
        }

        private void ClearAll()
        {
            pictureBox1.Image = null;
            textBox.Text = null;
            PassTextBox.Text = null;
            VideoTextPath.Text = null;
            progressBar.Value = 0;
        }

        private void MenuExtract_Click(object sender, EventArgs e)
        {
            ClearAll();
            for (int i = 1; i <= 3; i++)
            {
                videoController.CleanFolder(i);
            }
            ExtractForm Ex = new ExtractForm();
            Ex.Show();
            Hide();
        }

        private void MenuCompare_Click(object sender, EventArgs e)
        {
            ClearAll();
            for (int i = 0; i <= 3; i++)
            {
                videoController.CleanFolder(i);
            }
            CompareForm Co = new CompareForm();
            Co.Show();
            Hide();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            videoController.CleanFolder(1);
            videoController.CleanFolder(3);
            infoVideo = new string[7];

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileVideo = openFileDialog.FileName;
                VideoTextPath.Text = fileVideo;

                double time = Environment.TickCount;
                videoController.OpenVideo(fileVideo, 1);
                oriFrame = videoController.SelectedFrame();
                status.Text = "Select video done.";

                using (Bitmap bmp = new Bitmap(oriFrame))
                {
                    Bitmap image = new Bitmap(bmp);
                    pictureBox1.Image = image;
                    
                    for (int i = 1; i <= 6; i++)
                    {
                        infoVideo[i] = videoController.GetVideoInfo(i, fileVideo, image);
                    }
                    label1.Text = infoVideo[1];
                    label2.Text = infoVideo[2];
                    label3.Text = infoVideo[3];
                    label4.Text = infoVideo[4];
                    label5.Text = infoVideo[5];
                    label6.Text = infoVideo[6];
                    status.Text = "Extract frame " + ((double)(Environment.TickCount - time) / 1000).ToString() + " sec.";
                }
                textBox.Enabled = true;
                PassTextBox.Enabled = true;
                BrowseBtn.Enabled = false;
                EmbedBtn.Enabled = true;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Browse Text | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileText = ofd.FileName;
                string[] File2Lines = System.IO.File.ReadAllLines(fileText.ToString());
                textBox.Lines = File2Lines;
            }
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            double time = Environment.TickCount;
            if (textBox.Text != "" && PassTextBox.Text != "")
            {
                encryptedText = frameProcessing.EncryptMessage(textBox.Text, PassTextBox.Text);
                encryptedTextBox.Text = encryptedText;
                status.Text = ((double)(Environment.TickCount - time) / 1000).ToString() + " sec.";
            }
            else
            {
                MetroMessageBox.Show(this, "Please input text and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EmbedBtn_Click(object sender, EventArgs e)
        {
            double time = Environment.TickCount;
            progressBar.Maximum = 1;
            progressBar.Value = 0;
            stegoFrame = new Bitmap(oriFrame);

            if (encryptedTextBox.Text != "")
            {
                secretText = encryptedTextBox.Text;
            }
            else
            {
                secretText = textBox.Text;
            }

            if (encryptedTextBox.Text == "" && textBox.Text == "")
            {
                MetroMessageBox.Show(this, "The text you want to hide can not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stegoFrame = frameProcessing.Encode(stegoFrame, secretText);
                System.Threading.Thread.Sleep(1000);
                videoController.Save(stegoFrame);

                progressBar.Value++;
                status.Text = "Embed " + ((double)(Environment.TickCount - time) / 1000).ToString() + " sec.";
                MetroMessageBox.Show(this, "Message has been hidden successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void SecretTextBox_TextChanged(object sender, EventArgs e)
        {
            textCount1.Text = textBox.Text.Length.ToString();
        }

        private void encryptedTextBox_TextChanged(object sender, EventArgs e)
        {
            textCount2.Text = encryptedTextBox.Text.Length.ToString();
        }

        private void EmbedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                videoController.CleanFolder(i);
            }
            Application.Exit();
        }
        
    }
}
