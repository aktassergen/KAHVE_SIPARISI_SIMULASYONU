using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class KasiyerYonetimi
    {
        public List<Kasiyer> kasiyerList { get; set; }
        public KasiyerYonetimi()
        {
            kasiyerList = new List<Kasiyer>();
        }

        public void kasiyerEkle(Kasiyer kasiyer)
        {
            kasiyerList.Add(kasiyer);
        }

        public Kasiyer BosKasiyerBul()
        {

            return kasiyerList.FirstOrDefault(k => k.Durum);

            /*Bu kodda, kasiyerList adında bir liste içerisindeki elemanları kontrol eder. k => k.Durum ifadesi, 
             * her elemanın Durum özelliğini kontrol eder.
             * İlk bulunan elemanın Durum özelliği true ise bu elemanı döndürür. Eğer hiç eleman bu koşulu sağlamazsa,
             * default değeri olarak elemanın türünün varsayılan değerini döndürür (örneğin, sıfır veya null).
               Bu durumda, FirstOrDefault metodu kullanılarak mevcut durumu true olan ilk kasiyer nesnesini buluruz. 
               Eğer böyle bir kasiyer yoksa, null değeri dönecektir.
             */
        }

        public void SiparisAlVeHazirla(Musteri musteri)
        {
            Kasiyer kasiyer = BosKasiyerBul();
            if (kasiyer != null)
            {
                kasiyer.Durum = false; // Kasiyer meşgul
                Console.WriteLine($"{kasiyer.Id} siparişi alıyor...");
                Thread.Sleep(3*1000);//sparişin hazırlanmasi bekleniyor bunu da yaklaşık 3 dk olarak düşünelim
                Console.WriteLine($"{kasiyer.Id} siparişi hazırladı.");
                kasiyer.Durum = true; // Kasiyer boşta
            }
            else
            {
                Kasiyer bosKasiyer = BosKasiyerBul();
                if (bosKasiyer != null)
                {
                    bosKasiyer.Durum = false; // Bos kasiyeri meşgul yap
                    Console.WriteLine($"{bosKasiyer.Id} siparişi alıyor...");
                    Thread.Sleep(3 * 1000);
                    Console.WriteLine($"{bosKasiyer.Id} siparişi hazırladı.");
                    bosKasiyer.Durum = true; // Bos kasiyeri boşta yap
                }
                else
                {
                    Console.WriteLine("Boşta kasiyer yok. Sipariş bekletiliyor...");
                }
            }
        }
    }
}
