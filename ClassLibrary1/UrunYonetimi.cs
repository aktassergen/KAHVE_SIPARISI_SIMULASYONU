using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UrunYonetimi
    {
        public List<Urun> urunList;
        public UrunYonetimi()
        {
            urunList = new List<Urun>();
        }

        public void urunEkle(Urun Urun)
        {
            urunList.Add(Urun);
        }
       
    }
}
