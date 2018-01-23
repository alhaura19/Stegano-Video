using System;
using System.Drawing;

namespace StegoVideo.Controller
{
    public class DWT
    {
        //private const double s0 = 0.5;
        //private const double s1 = 0.5;
        //private const double w0 = 0.5;
        //private const double w1 = -0.5;

        public DWT()
        {

        }

        private void FWT(double[] data)
        {
            double[] temp = new double[data.Length];

            int h = data.Length >> 1;
            for (int i = 0; i < h; i++)
            {
                int k = (i << 1);
                temp[i] = Math.Floor((data[k] + data[k + 1]) / 2);
                temp[i + h] = data[k] - data[k + 1];
                //temp[i] = data[k] * s0 + data[k + 1] * s1;
                //temp[i + h] = data[k] * w0 + data[k + 1] * w1;
            }

            for (int i = 0; i < data.Length; i++)
                data[i] = temp[i];
        }

        public void FWT(double[,] data, int iterations)
        {

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            double[] row;
            double[] col;

            for (int k = 0; k < iterations; k++)
            {
                int lev = 1 << k;

                int levCols = cols / lev;
                int levRows = rows / lev;

                row = new double[levCols];
                for (int i = 0; i < levRows; i++)
                {
                    for (int j = 0; j < row.Length; j++)
                        row[j] = data[i, j];

                    FWT(row);

                    for (int j = 0; j < row.Length; j++)
                        data[i, j] = row[j];
                }


                col = new double[levRows];
                for (int j = 0; j < levCols; j++)
                {
                    for (int i = 0; i < col.Length; i++)
                        col[i] = data[i, j];

                    FWT(col);

                    for (int i = 0; i < col.Length; i++)
                        data[i, j] = col[i];
                }

            }
        }

        private void IWT(double[] data)
        {
            double[] temp = new double[data.Length];

            int h = data.Length >> 1;
            for (int i = 0; i < h; i++)
            {
                int k = (i << 1);
                temp[k] = data[i] + Math.Floor((data[i + h] + 1) / 2);
                temp[k + 1] = data[i] - Math.Floor(data[i + h] / 2);
                //temp[k] = (data[i] * s0 + data[i + h] * w0) / w0;
                //temp[k + 1] = (data[i] * s1 + data[i + h] * w1) / s0;
            }

            for (int i = 0; i < data.Length; i++)
                data[i] = temp[i];
        }

        public void IWT(double[,] data, int iterations)
        {

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            double[] col;
            double[] row;

            for (int k = 0; k < iterations; k++)
            {
                col = new double[rows];
                for (int j = 0; j < cols; j++)
                {
                    for (int i = 0; i < col.Length; i++)
                        col[i] = data[i, j];

                    IWT(col);

                    for (int i = 0; i < col.Length; i++)
                        data[i, j] = col[i];
                }

                row = new double[cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < row.Length; j++)
                        row[j] = data[i, j];

                    IWT(row);

                    for (int j = 0; j < row.Length; j++)
                        data[i, j] = row[j];
                }
            }
        }

        public void normalize(double[,] val)
        {
            for (int i = 0; i < val.GetLength(0); i++)
            {
                for (int j = 0; j < val.GetLength(1); j++)
                {
                    if (val[i, j] >= 255)
                        val[i, j] = 255;
                    else if (val[i, j] <= 0)
                        val[i, j] = 1;
                    //else if (val[i, j] < 0 && val[i, j] % 2 == 0)
                    //    val[i, j] = 2;
                    //else if (val[i, j] < 0 && val[i, j] % 2 != 0)
                    //    val[i, j] = 1;
                    else
                        val[i, j] = val[i, j];
                }
            }
        }

        public Bitmap ApplyHaarTransform(Bitmap img, bool Forward)
        {
            int Iterations = 1;

            double[,] Red = new double[img.Width, img.Height];
            double[,] Green = new double[img.Width, img.Height];
            double[,] Blue = new double[img.Width, img.Height];

            Color c;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    c = img.GetPixel(i, j);
                    Red[i, j] = c.R;
                    Green[i, j] = c.G;
                    Blue[i, j] = c.B;
                }
                
            }

            if (Forward)
            {
                FWT(Red, Iterations);
                FWT(Green, Iterations);
                FWT(Blue, Iterations);
            }
            else
            {
                IWT(Red, Iterations);
                IWT(Green, Iterations);
                IWT(Blue, Iterations);
            }

            normalize(Red);
            normalize(Green);
            normalize(Blue);

            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {
                    img.SetPixel(i, j, Color.FromArgb((int)Red[i, j], (int)Green[i, j], (int)Blue[i, j]));
                    //img.SetPixel(i, j, Color.FromArgb((int)Scale(-1, 1, 0, 255, Red[i, j]), (int)Scale(-1, 1, 0, 255, Green[i, j]), (int)Scale(-1, 1, 0, 255, Blue[i, j])));
                }
            }

            return img;
        }
    }
}
