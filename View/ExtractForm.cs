using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using StegoVideo.Controller;

namespace StegoVideo.View
{
    public partial class ExtractForm : MetroForm
    {
        VideoController videoController;
        FrameProcessing frameProcessing;
        Bitmap stegoFrame = null;

        public ExtractForm()
        {
            InitializeComponent();
            videoController = new VideoController();
            frameProcessing = new FrameProcessing();
            PassTextBox.Enabled = false;
            ExtractBtn.Enabled = false;
        }

        private void ClearAll()
        {
            pictureBox1.Image = null;
            SecretTextBox.Text = null;
            PassTextBox.Text = null;
            VideoTextPath.Text = null;
            progressBar.Value = 0;
        }

        private void MenuHide_Click(object sender, EventArgs e)
        {
            ClearAll();
            for (int i = 0; i < 3; i++)
            {
                videoController.CleanFolder(i);
            }
            EmbedForm Em = new EmbedForm();
            Em.Show();
            Hide();
        }

        private void MenuCompare_Click(object sender, EventArgs e)
        {
            ClearAll();
            for (int i = 0; i < 3; i++)
            {
                videoController.CleanFolder(i);
            }
            CompareForm Co = new CompareForm();
            Co.Show();
            Hide();
        }

        private void BrowseBtn_Click_1(object sender, EventArgs e)
        {
            ClearAll();
            videoController.CleanFolder(1);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                VideoTextPath.Text = filename;

                double time = Environment.TickCount;
                videoController.OpenVideo(filename, 1);
                stegoFrame = videoController.SelectedFrame();

                using (Bitmap bmp = new Bitmap(stegoFrame))
                {
                    Bitmap newbmp = new Bitmap(bmp);
                    pictureBox1.Image = newbmp;
                }
                status.Text = "Extract frame " + ((double)(Environment.TickCount - time) / 1000).ToString() + " sec.";
                
                PassTextBox.Enabled = true;
                ExtractBtn.Enabled = true;
                BrowseBtn.Enabled = false;
            }
            
        }

        private void ExtractBtn_Click(object sender, EventArgs e)
        {
            double time = Environment.TickCount;
            progressBar.Maximum = 1;
            progressBar.Value = 0;
            string text = null;
            
            text = frameProcessing.decode(stegoFrame);

            SecretTextBox.Text = text;
            videoController.ClearResource();
            progressBar.Value++;
            status.Text = "Extract " + ((double)(Environment.TickCount - time) / 1000).ToString() + " sec.";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string text = SecretTextBox.Text;
            try
            {
                text = frameProcessing.DecryptMessage(text, PassTextBox.Text);
            }
            catch
            {
                MetroMessageBox.Show(this, "Can not decrypt message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SecretTextBox.Text = text;
        }

        private void SecretTextBox_TextChanged(object sender, EventArgs e)
        {
            TextCount.Text = SecretTextBox.Text.Length.ToString();
        }

        private void ExtractForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                videoController.CleanFolder(i);
            }
            Application.Exit();
        }
        
    }
}
