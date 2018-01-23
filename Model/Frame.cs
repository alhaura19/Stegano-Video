using System.Drawing;

namespace StegoVideo.Model
{
    public class Frame
    {
        private Bitmap originalmage;
        private Bitmap stegoImage;

        public Bitmap OriginalFrame
        {
            get { return originalmage; }
            set
            {
                originalmage = value;
            }
        }

        public Bitmap StegoFrame
        {
            get { return stegoImage; }
            set
            {
                stegoImage = value;
            }
        }

    }
}
