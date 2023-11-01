using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Urun
    {
        public string UrunId { get; set; }
        public int HazirlanmaZamani { get; }
        public int BegenilmePuani { get; }
        //encapsulleme
        private decimal _fiyat; // Fiyat özelliği private olarak tanımlanıyor
        public decimal Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        private List<string> _ilaveler = new List<string>(); // Ilaveler özelliği private olarak tanımlanıyor encapsulleme

        public Urun(string urunId, int hazirlanmaZamani, int begenilmePuani, decimal fiyat)
        {
            UrunId = urunId;
            HazirlanmaZamani = hazirlanmaZamani;
            BegenilmePuani = begenilmePuani;
            Fiyat = fiyat;
        }

        // Karemel, şeker gibi ilaveler eklenebilir
        public void IlaveEkle(string ilave)
        {
            _ilaveler.Add(ilave);
        }

        public void IlaveCikar(string ilave)
        {
            _ilaveler.Remove(ilave);
        }

        // IlaveleriGetir metodu void olarak düzenlendiği için geriye bir şey döndürmüyor
        public void IlaveleriGetir()
        {
            foreach (string i in _ilaveler)
            {
                Console.WriteLine(i);
            }
        }
    }
}
