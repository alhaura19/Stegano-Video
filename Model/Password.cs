namespace StegoVideo.Model
{
    public class Password : Text
    {
        private string pass;

        public string password
        {
            get { return pass; }
            set
            {
                pass = value;
            }
        }

    }
}
