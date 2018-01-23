using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StegoVideo.Controller;

namespace StegoVideo.View
{
    public partial class Compare2 : Form
    {
        public Compare2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double asli = textBox1.Text.Length;
            int error = CompareString.Compute(textBox1.Text, textBox2.Text);
            double akurasi = (asli - error) / asli * 100;

            label1.Text = "Akurasi : " + akurasi.ToString() + " %";
            label2.Text = "Jumlah kata yang error : " + error.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text.Length.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox2.Text.Length.ToString();
        }
    }
}
