namespace ClassLibrary1
{
    
    public class Calisan
    {
        //encapsulleme
        private string _id;
        private bool _durum;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool Durum
        {
            get { return _durum; }
            set { _durum = value; }
        }
    }
}