using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using StegoVideo.Controller;

namespace StegoVideo.View
{
    public partial class CompareForm : MetroForm
    {
        VideoController videoController;
        Metrics metrics;
        Bitmap img1 = null;
        Bitmap img2 = null;
        string[] imgArr1;
        string[] imgArr2;
        string file1, file2;
        string text1;
        string text2;

        public CompareForm()
        {
            InitializeComponent();
            videoController = new VideoController();
            metrics = new Metrics();
        }

        private void MenuHide_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                videoController.CleanFolder(i);
            }
            EmbedForm Em = new EmbedForm();
            Em.Show();
            Hide();
        }

        private void MenuExtract_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                videoController.CleanFolder(i);
            }
            ExtractForm Ex = new ExtractForm();
            Ex.Show();
            Hide();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            videoController.CleanFolder(1);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                file1 = filename;
                VideoTextPath.Text = filename;

                videoController.OpenVideo(filename, 1);
                imgArr1 = videoController.Frames();
                img1 = videoController.ChosenFrame1();
                pictureBox1.Image = img1;
            }
        }

        private void BrowseBtn2_Click(object sender, EventArgs e)
        {
            videoController.CleanFolder(2);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                file2 = filename;
                VideoTextPath2.Text = filename;

                videoController.OpenVideo(filename, 2);
                imgArr2 = videoController.Frames2();
                img2 = videoController.ChosenFrame2();
                pictureBox2.Image = img2;
            }
        }

        private void btnText1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Browse Text | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] File2Lines = System.IO.File.ReadAllLines(ofd.FileName.ToString());

                textBox1.Lines = File2Lines;
            }
        }

        private void btnText2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Browse Text | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] File2Lines = System.IO.File.ReadAllLines(ofd.FileName.ToString());

                textBox2.Lines = File2Lines;
            }
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            double mse = metrics.MSE(img1, img2);
            label1.Text = "Size video 1: " + videoController.GetVideoInfo(1, file1, img1).ToString();
            label2.Text = "Size video 2: " + videoController.GetVideoInfo(1, file2, img2).ToString();
            label3.Text = "MSE: " + mse.ToString();
            label4.Text = "PSNR: " + metrics.PSNR(mse).ToString();
            //label5.Text = "SSIM: " + metrics.SSIM(imgArr1, imgArr2).ToString();
            label5.Text = "SSIM: " + metrics.SSIM(img1, img2).ToString();
            videoController.ClearResource();
            Console.WriteLine(metrics.PSNR(17.6998));
        }

        private void processBtn2_Click(object sender, EventArgs e)
        {
            text1 = textBox1.Text;
            text2 = textBox2.Text;
            double error = metrics.CompareString(text1, text2);
            double similarity = metrics.CalculateSimilarity(error, text1.Length);
            label6.Text = similarity.ToString() + " %";
            label7.Text = error.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text.Length.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label9.Text = textBox2.Text.Length.ToString();
        }

        private void CompareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                videoController.CleanFolder(i);
            }
            Application.Exit();
        }
    }
}
