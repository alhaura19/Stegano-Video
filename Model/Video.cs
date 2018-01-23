using System.IO;
using System.Drawing;
using AForge.Video.FFMPEG;

namespace StegoVideo.Model
{
    public class Video
    {
        private VideoFileReader reader;
        private double size;
        private string filename;
        private int framecount, framerate, duration, bitrate, width, height;

        public Video(string filename, Bitmap img)
        {
            reader = new VideoFileReader();
            reader.Open(filename);
            this.filename = filename;
            this.size = new FileInfo(filename).Length;
            this.width = img.Width;
            this.height = img.Height;
            this.framecount = (int)reader.FrameCount;
            this.framerate = reader.FrameRate;
            this.duration = framecount / framerate;
            this.bitrate = (int) width * height * framerate * 24;
        }

        public double Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }

        public int FrameCount
        {
            get { return framecount; }
            set
            {
                framecount = value;
            }
        }

        public int FrameRate
        {
            get { return framerate; }
            set
            {
                framerate = value;
            }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
            }
        }

        public int BitRate
        {
            get { return bitrate; }
            set
            {
                bitrate = value;
            }
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        
    }
}
