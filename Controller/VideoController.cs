using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using AForge.Video.FFMPEG;
using StegoVideo.Model;

namespace StegoVideo.Controller
{
    public class VideoController
    {
        Video video;
        VideoFileReader reader;
        VideoFileReader reader2;
        VideoFileWriter writer;
        DirectoryInfo di;
        FileInfo[] files;
        Bitmap img;
        Bitmap videoFrame;
        string folderName, folderName2, folderName3;
        string filename;

        public VideoController()
        {
            reader = new VideoFileReader();
            reader2 = new VideoFileReader();
            writer = new VideoFileWriter();

            folderName = AppDomain.CurrentDomain.BaseDirectory + "\\tmp\\";
            folderName2 = AppDomain.CurrentDomain.BaseDirectory + "\\tmp2\\";
            folderName3 = AppDomain.CurrentDomain.BaseDirectory + "\\foldertmp\\";

            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);

            if (!Directory.Exists(folderName2))
                Directory.CreateDirectory(folderName2);

            if (!Directory.Exists(folderName3))
                Directory.CreateDirectory(folderName3);
        }

        public void CleanFolder(int x)
        {
            if (x == 1)
            {
                Array.ForEach(Directory.GetFiles(folderName), File.Delete);
            }
            else if (x == 2)
            {
                Array.ForEach(Directory.GetFiles(folderName2), File.Delete);
            }
            else if (x == 3)
            {
                Array.ForEach(Directory.GetFiles(folderName3), File.Delete);
            }
            
        }

        public void OpenVideo(string file, int x)
        {
            if (x == 1)
            {
                filename = file;
                reader.Open(filename);
                Thread.Sleep(100);
                ExtractVideo(1);
            }
            else if (x == 2)
            {
                filename = file;
                reader2.Open(filename);
                Thread.Sleep(100);
                ExtractVideo(2);
            }
            
        }

        private void ExtractVideo(int x)
        {
            if (x == 1)
            {
                for (int i = 0; i < reader.FrameCount; i++)
                {
                    videoFrame = reader.ReadVideoFrame();
                    videoFrame.Save(folderName + i + ".bmp");
                }
            }
            else if (x == 2)
            {
                for (int i = 0; i < reader2.FrameCount; i++)
                {
                    videoFrame = reader2.ReadVideoFrame();
                    videoFrame.Save(folderName2 + i + ".bmp");
                }
            }
            
        }

        public string[] Frames()
        {
            di = new DirectoryInfo(folderName);
            files = di.GetFiles("*.bmp");

            string[] frames = files.OrderBy(fi => int.Parse(fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length))).Select(fi => fi.FullName).ToArray();
            
            return frames;
        }

        public string[] Frames2()
        {
            di = new DirectoryInfo(folderName2);
            files = di.GetFiles("*.bmp");

            string[] frames = files.OrderBy(fi => int.Parse(fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length))).Select(fi => fi.FullName).ToArray();

            return frames;
        }

        public Bitmap SelectedFrame()
        {
            Bitmap selectedFrame;
            string[] frames;
            int index;

            frames = Frames();
            index = frames.Length / 2;
            using (Bitmap chosenFrame = new Bitmap(frames[index]))
            {
                chosenFrame.Save(folderName3 + index + ".bmp");
            }
            using (Bitmap x = new Bitmap(folderName3 + index + ".bmp"))
            {
                selectedFrame = new Bitmap(x);
                File.Delete(frames[index]);
            }

            return selectedFrame;
        }

        public Bitmap ChosenFrame1()
        {
            Bitmap chosenframe;
            string[] images = Frames();
            int index = images.Length / 2;

            using (Bitmap image = new Bitmap(images[index]))
            {
                chosenframe = new Bitmap(image);
            }
            return chosenframe;
        }

        public Bitmap ChosenFrame2()
        {
            Bitmap chosenframe;
            string[] images = Frames2();
            int index = images.Length / 2;

            using (Bitmap image = new Bitmap(images[index]))
            {
                chosenframe = new Bitmap(image);
            }
            return chosenframe;
        }

        public void Save(Bitmap image)
        {
            img = image;
            int i = files.Length / 2;
            img.Save(folderName + i + ".bmp");
            CreateVideo();
            ClearResource();
        }

        public void CreateVideo()
        {
            Bitmap newFrame;
            string[] frames = Frames();
            video = new Video(filename, img);
            int length = frames.Length;
            int width = video.Width;
            int height = video.Height;
            int framerate = video.FrameRate;
            int bitrate = video.BitRate;
            string filepath = @"D:\Files\Tugas Akhir\TA\Folder Video\stego1.avi";
            
            int x = 0;
            while (File.Exists(filepath))
            {
                x++;
                filepath = @"D:\Files\Tugas Akhir\TA\Folder Video\stego" + x + ".avi";
            }

            string stegovideo = Path.Combine(filepath);
            writer.Open(stegovideo, width, height, reader.FrameRate, VideoCodec.Raw, bitrate);
            for (int i = 0; i < reader.FrameCount; i++)
            {
                newFrame = (Bitmap)Image.FromFile(frames[i]);
                writer.WriteVideoFrame(newFrame);
                newFrame.Dispose();
            }
        }

        public string GetVideoInfo(int i, string file, Bitmap bmp)
        {
            video = new Video(file, bmp);
            string info = "";
            if (i == 1)
            {
                info = "Size: " + video.Size * 0.001 + " KB";
            }
            else if (i == 2)
            {
                info = "Length: " + video.Duration + " Sec.";
            }
            else if (i == 3)
            {
                info = "Width: " + video.Width;
            }
            else if (i == 4)
            {
                info = "Height: " + video.Height;
            }
            else if (i == 5)
            {
                info = "Framerate: " + video.FrameRate + " frames/sec.";
            }
            else if (i == 6)
            {
                info = "Total Frame: " + video.FrameCount;
            }
            return info;
        }

        public void ClearResource()
        {
            writer.Close();
            videoFrame.Dispose();
            reader.Close();
            reader2.Close();
        }

    }
}
