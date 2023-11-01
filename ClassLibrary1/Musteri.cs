using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Musteri
    {

        public string MusteriId { get; set; }
        public Urun SiparisId { get; set; }
        public Musteri(string musteriId, Urun siparisId)
        {
            MusteriId = musteriId;
            SiparisId = siparisId;
        }

      

        public void UrunIlaveEkle(Urun urun, string ilave)
        {
            urun.IlaveEkle(ilave);
        }

        public void UrunIlaveCikar(Urun urun, string ilave)
        {
            urun.IlaveCikar(ilave);
        }

        public void OdemeYap()
        {
            Console.WriteLine(SiparisId.UrunId+ " için Ödeme yapılıyor ve tutat: " + SiparisId.Fiyat);

        }

        public void SiparisHazır(Barista barista)
        {
          
            barista.SiparisiHazirla(this);
            Console.WriteLine($"{SiparisId.UrunId} :sipariş hazırlandı {MusteriId} siparişi aldı ve gidiyor ");
        }

    }
}
