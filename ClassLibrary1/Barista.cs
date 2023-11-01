using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Barista:Calisan
    {
        public Barista(string BaristaId)
        {
            Id=BaristaId;
        }

        public void SiparisiHazirla(Musteri musteri)
        {
            Thread.Sleep(musteri.SiparisId.HazirlanmaZamani*1000);//1000 1 saniyeye denk geldiği için çarpma işlemi
            Console.WriteLine($"{Id} siparişi hazırladı: {musteri.SiparisId.UrunId}");
        }
    }
}
