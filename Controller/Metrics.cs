using System;
using System.Drawing;
using StegoVideo.Controller;

namespace StegoVideo.Controller
{
    public class Metrics
    {
        public Metrics()
        {
            //string[] imgArr1, string[] imgArr2, Bitmap img1, Bitmap img2
            //this.image1 = img1;
            //this.image2 = img2;
            //this.imageArr1 = imgArr1;
            //this.imageArr2 = imgArr2;
        }

        public double MSE(Bitmap image1, Bitmap image2)
        {
            int M = image1.Height;
            int N = image1.Width;
            double mse;

            double R = 0, G = 0, B = 0;
            double R2 = 0, G2 = 0, B2 = 0;
            double sum = 0;
            //double sum1, sum2, sum3;
           
            for (int j = 0; j < M; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    R = image1.GetPixel(i, j).R;
                    G = image1.GetPixel(i, j).G;
                    B = image1.GetPixel(i, j).B;

                    R2 = image2.GetPixel(i, j).R;
                    G2 = image2.GetPixel(i, j).G;
                    B2 = image2.GetPixel(i, j).B;

                    //sum1 = R - R2;
                    //sum2 = G - G2;
                    //sum3 = B - B2;
                    //sum4 = (sum1 + sum2 + sum3);
                    //sum += Math.Pow(sum4, 2);
                    //sum += Math.Pow(((R + G + B) - (R2 + G2 + B2)), 2);
                    //sum1 = Math.Pow(R - R2, 2);
                    //sum2 = Math.Pow(G - G2, 2);
                    //sum3 = Math.Pow(B - B2, 2);
                    //sum += (sum1 + sum2 + sum3) / 3;
                    sum += (Math.Pow(R - R2, 2) + Math.Pow(G - G2, 2) + Math.Pow(B - B2, 2)) / 3;
                }
            }
            mse = sum / (3* M * N);

            return mse;
        }

        public double PSNR(double mse)
        {
            double psnr;
            psnr = 20 * Math.Log10(255 / Math.Sqrt(mse));
            return psnr;
        }

        private static double Mean(Bitmap A)
        {
            double mean;
            double R = 0, G = 0, B = 0;

            for (int j = 0; j < A.Height; j++)
            {
                for (int i = 0; i < A.Width; i++)
                {
                    Color c = A.GetPixel(i, j);
                    R += c.R;
                    G += c.G;
                    B += c.B;
                }
            }
            R /= (A.Height * A.Width);
            G /= (A.Height * A.Width);
            B /= (A.Height * A.Width);

            mean = (R + G + B) / 3;

            return mean;
        }

        private double Variance(Bitmap A, double Mean)
        {
            double variance = 0;

            double R = 0, G = 0, B = 0;

            for (int j = 0; j < A.Height; j++)
            {
                for (int i = 0; i < A.Width; i++)
                {
                    Color c = A.GetPixel(i, j);
                    R = c.R;
                    G = c.G;
                    B = c.B;
                    variance += Math.Pow(((R + G + B) / 3) - Mean, 2);
                }
            }

            variance = variance / ((A.Height * A.Width) - 1);

            return variance;
        }

        private double Covariance(Bitmap A, Bitmap B, double Mean1, double Mean2)
        {
            double covariance = 0;

            double R1 = 0, G1 = 0, B1 = 0;
            double R2 = 0, G2 = 0, B2 = 0;

            for (int j = 0; j < A.Height; j++)
            {
                for (int i = 0; i < A.Width; i++)
                {
                    Color c1 = A.GetPixel(i, j);
                    Color c2 = B.GetPixel(i, j);

                    R1 = c1.R;
                    G1 = c1.G;
                    B1 = c1.B;

                    R2 = c2.R;
                    G2 = c2.G;
                    B2 = c2.B;

                    covariance += (((R1 + G1 + B1) / 3) - Mean1) * (((R2 + G2 + B2) / 3) - Mean2);
                }
            }
            covariance = covariance / ((A.Height * A.Width) - 1);

            return covariance;
        }

        private double C(double k)
        {
            double C, L;

            L = Math.Pow(2, 8) - 1;
            C = Math.Pow((k * L), 2);

            return C;
        }

        public double SSIM(Bitmap imageArr1, Bitmap imageArr2)
        {
            double ssim = 0;
            double m1, m2, c1, c2, cov, v1, v2;
            Bitmap image1, image2;

                image1 = new Bitmap(imageArr1);
                image2 = new Bitmap(imageArr2);
                m1 = Mean(image1);
                m2 = Mean(image2);
                c1 = C(0.01);
                c2 = C(0.03);
                cov = Covariance(image1, image2, m1, m2);
                v1 = Variance(image1, m1);
                v2 = Variance(image2, m2);
                ssim += (((2 * m1 * m2) + c1) * ((2 * cov) + c2)) / ((Math.Pow(m1, 2) + Math.Pow(m2, 2) + c1) * (v1 + v2 + c2));
                image1.Dispose();
                image2.Dispose();

            return ssim;
        }

        //public double SSIM(string[] imageArr1, string[] imageArr2)
        //{
        //    double ssim = 0;
        //    double m1, m2, c1, c2, cov, v1, v2;
        //    Bitmap image1, image2;

        //    for (int i = 0; i < imageArr1.Length; i++)
        //    {
        //        image1 = new Bitmap(imageArr1[i]);
        //        image2 = new Bitmap(imageArr2[i]);
        //        m1 = Mean(image1);
        //        m2 = Mean(image2);
        //        c1 = C(0.01);
        //        c2 = C(0.03);
        //        cov = Covariance(image1, image2, m1, m2);
        //        v1 = Variance(image1, m1);
        //        v2 = Variance(image2, m2);
        //        ssim += (((2 * m1 * m2) + c1) * ((2 * cov) + c2)) / ((Math.Pow(m1, 2) + Math.Pow(m2, 2) + c1) * (v1 + v2 + c2));
        //        image1.Dispose();
        //        image2.Dispose();
        //    }

        //    ssim = ssim / imageArr1.Length;

        //    return ssim;
        //}

        public double CompareString(string text1, string text2)
        {
            double error;
            if(string.IsNullOrEmpty(text1))
            {
                if (string.IsNullOrEmpty(text2))
                    return 0;
                return text2.Length;
            }

            if (string.IsNullOrEmpty(text2))
            {
                return text1.Length;
            }

            int n = text1.Length;
            int m = text2.Length;
            int[,] d = new int[n + 1, m + 1];

            // initialize the top and right of the table to 0, 1, 2, ...
            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 1; j <= m; d[0, j] = j++) ;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (text2[j - 1] == text1[i - 1]) ? 0 : 1;
                    int min1 = d[i - 1, j] + 1;
                    int min2 = d[i, j - 1] + 1;
                    int min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }
            error = d[n, m];
            return d[n, m];
        }

        public double CalculateSimilarity(double error, double asli)
        {
            //1-(error/asli) * 100l;l/ll
            return (1.0 - (error / asli)) * 100;
        }

    }
    
}
