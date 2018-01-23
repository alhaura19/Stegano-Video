namespace StegoVideo.Model
{
    public class Text
    {
        private string originalText;
        private string encryptedText;

        public string OriginalText
        {
            get { return originalText; }
            set
            {
                originalText = value;
            }
        }

        public string EncryptedText
        {
            get { return encryptedText; }
            set
            {
                encryptedText = value;
            }
        }
    }
}
