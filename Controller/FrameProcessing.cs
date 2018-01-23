using System;
using System.Drawing;
using System.Collections.Generic;

namespace StegoVideo.Controller
{
    public class FrameProcessing
    {
        DES des;
        DWT dwt;
        LSB lsb;
        Image[] imageArray = new Image[4];
        Image[] imageArrast = new Image[2];
        Image[] imageArray2 = new Image[4];

        public FrameProcessing()
        {
            des = new DES();
            dwt = new DWT();
            lsb = new LSB();
        }

        public string EncryptMessage(string message, string password)
        {
            message = des.Encrypt(message, password);
            return message;
        }

        public Bitmap Encode(Bitmap img, string message)
        {
            int m = img.Width;
            int n = img.Height;

            double[,] R = new double[m, n];
            double[,] G = new double[m, n];
            double[,] B = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Color c = img.GetPixel(i, j);

                    R[i, j] = c.R;
                    G[i, j] = c.G;
                    B[i, j] = c.B;
                }
            }

            dwt.FWT(R, 1);
            dwt.FWT(G, 1);
            dwt.FWT(B, 1);

            dwt.normalize(R);
            dwt.normalize(G);
            dwt.normalize(B);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    img.SetPixel(i, j, Color.FromArgb((int)R[i, j], (int)G[i, j], (int)B[i, j]));
                }
            }

            //img.Save("hai.bmp");
            img = PreProcessing(img);
            //img.Save("hai2.bmp");
            img = lsb.Embed(message, img);
            //img = he(img);
            //img.Save("hai3.bmp");
            img = PraProcessing(img);
            List<string> test2 = new List<string>();
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    R[i, j] = c.R;
                    //G[i, j] = c.G;
                    //B[i, j] = c.B;
                    test2.Add(R.GetValue(i, j).ToString());
                }
            }
            System.IO.File.WriteAllLines(@"D:\Files\Tugas Akhir\TA\StegoVideo\ok.txt", test2);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Color c = img.GetPixel(i, j);

                    R[i, j] = c.R;
                    G[i, j] = c.G;
                    B[i, j] = c.B;
                }
            }

            dwt.IWT(R, 1);
            dwt.IWT(G, 1);
            dwt.IWT(B, 1);

            dwt.normalize(R);
            dwt.normalize(G);
            dwt.normalize(B);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    img.SetPixel(i, j, Color.FromArgb((int)R[i, j], (int)G[i, j], (int)B[i, j]));
                }
            }
            return img;
        }

        public string decode(Bitmap img)
        {
            string message = null;
            int m = img.Width;
            int n = img.Height;

            double[,] R = new double[m, n];
            double[,] G = new double[m, n];
            double[,] B = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Color c = img.GetPixel(i, j);

                    R[i, j] = c.R;
                    G[i, j] = c.G;
                    B[i, j] = c.B;
                }
            }

            dwt.FWT(R, 1);
            dwt.FWT(G, 1);
            dwt.FWT(B, 1);

            dwt.normalize(R);
            dwt.normalize(G);
            dwt.normalize(B);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    img.SetPixel(i, j, Color.FromArgb((int)R[i, j], (int)G[i, j], (int)B[i, j]));
                }
            }
            List<string> test2 = new List<string>();

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    R[i, j] = c.R;
                    //G[i, j] = c.G;
                    //B[i, j] = c.B;
                    test2.Add(R.GetValue(i, j).ToString());
                }
            }
            System.IO.File.WriteAllLines(@"D:\Files\Tugas Akhir\TA\StegoVideo\ok1.txt", test2);
            img = PreProcessing(img);
            img.Save("hai4.bmp");
            //img.Save("hai5.bmp");
            message = lsb.Extract(img);
            return message;
        }

        public string DecryptMessage(string message, string password)
        {
            message = des.Decrypt(message, password);
            return message;
        }

        private Bitmap PreProcessing(Bitmap img)
        {
            int width = img.Width / 2;
            int height = img.Height + img.Height;
            //int width = img.Width / 2;
            //int height = img.Height;
            Bitmap newImg = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(newImg);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var index = i * 2 + j;
                    imageArray[index] = new Bitmap(img.Width / 2, img.Height / 2);
                    var graphics = Graphics.FromImage(imageArray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, img.Width / 2, img.Height / 2), new Rectangle(i * img.Width / 2, j * img.Height / 2, img.Width / 2, img.Height / 2), GraphicsUnit.Pixel);

                    //imageArray[index].Save("oke" + index++ + ".bmp");
                    graphics.Dispose();
                }
            }

            g.DrawImage(imageArray[0], new Point(0, 0));
            g.DrawImage(imageArray[1], new Point(0, imageArray[0].Height));
            g.DrawImage(imageArray[2], new Point(0, imageArray[0].Height * 2));
            g.DrawImage(imageArray[3], new Point(0, imageArray[0].Height * 3));
            //g.DrawImage(imageArray[1], new Point(0, 0));
            //g.DrawImage(imageArray[3], new Point(0, imageArray[0].Height));
            g.Dispose();

            return newImg;
        }

        private Bitmap he(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height * 2;
            Bitmap newImg = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(newImg);

            g.DrawImage(imageArray[0], new Point(0, 0));
            g.DrawImage(imageArray[2], new Point(0, imageArray[0].Height));
            g.DrawImage(img, new Point(0, imageArray[0].Height * 2));
            g.Dispose();
            return newImg;
        }

        private Bitmap PraProcessing(Bitmap img)
        {
            int width = img.Width * 2;
            int height = img.Height / 2;
            Bitmap newImg = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(newImg);

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = i * 4 + j;
                    imageArray2[index] = new Bitmap(img.Width, img.Height / 4);
                    var graphics = Graphics.FromImage(imageArray2[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height / 4), new Rectangle(i * img.Width, j * img.Height / 4, img.Width, img.Height / 4), GraphicsUnit.Pixel);

                    //imageArray2[index].Save("oke" + index++ + ".bmp");
                    graphics.Dispose();
                }
            }
            
            g.DrawImage(imageArray2[0], new Point(0, 0));
            g.DrawImage(imageArray2[1], new Point(imageArray2[0].Width, 0));
            g.DrawImage(imageArray2[2], new Point(0, imageArray2[0].Height));
            g.DrawImage(imageArray2[3], new Point(imageArray2[2].Width, imageArray2[1].Height));
            
            return newImg;
        }

    }
}

//int width = img1.Width / 2;
//int height = img1.Height + img1.Height;
//Bitmap newImg1 = new Bitmap(width, height);
//Graphics g = Graphics.FromImage(newImg1);
//            for (int i = 0; i< 2; i++)
//            {
//                for (int j = 0; j< 2; j++)
//                {
//                    var index = i * 2 + j;
//imageArray[index] = new Bitmap(img1.Width / 2, img1.Height / 2);
//var graphics = Graphics.FromImage(imageArray[index]);
//graphics.DrawImage(img1, new Rectangle(0, 0, img1.Width / 2, img1.Height / 2), new Rectangle(i* img1.Width / 2, j* img1.Height / 2, img1.Width / 2, img1.Height / 2), GraphicsUnit.Pixel);
//                    //imageArray[index].Save("oke" + index++ + ".bmp");
//                    graphics.Dispose();
//                }
//            }
//            g.DrawImage(imageArray[0], new Point(0, 0));
//            g.DrawImage(imageArray[1], new Point(0, imageArray[0].Height));
//            g.DrawImage(imageArray[2], new Point(0, imageArray[0].Height* 2));
//            g.DrawImage(imageArray[3], new Point(0, imageArray[0].Height* 3));
//            newImg1.Save("1.bmp");
//            g.Dispose();
//            lsb.Embed(message, img);
//            //praProcessing(img1);
//            int width2 = newImg1.Width * 2;
//int height2 = newImg1.Height / 2;
//Bitmap newImg2 = new Bitmap(width, height);
//Graphics g2 = Graphics.FromImage(newImg2);
//            for (int i = 0; i< 1; i++)
//            {
//                for (int j = 0; j< 4; j++)
//                {
//                    var index = i * 4 + j;
//imageArray2[index] = new Bitmap(newImg1.Width, newImg1.Height / 4);
//var graphics = Graphics.FromImage(imageArray2[index]);
//graphics.DrawImage(newImg1, new Rectangle(0, 0, newImg1.Width, newImg1.Height / 4), new Rectangle(i* newImg1.Width, j* newImg1.Height / 4, newImg1.Width, newImg1.Height / 4), GraphicsUnit.Pixel);
//                    //imageArray2[index].Save("oke" + index++ + ".bmp");
//                    graphics.Dispose();
//                }
//            }
//            g2.DrawImage(imageArray2[0], new Point(0, 0));
//            g2.DrawImage(imageArray2[1], new Point(imageArray2[0].Width, 0));
//            g2.DrawImage(imageArray2[2], new Point(0, imageArray2[0].Height));
//            g2.DrawImage(imageArray2[3], new Point(imageArray2[2].Width, imageArray2[1].Height));
//            newImg2.Save("2.bmp");