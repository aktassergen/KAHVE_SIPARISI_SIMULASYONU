using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CalisanHavuzu
    {
        public List<Calisan> calisanList { get; set; }

        public CalisanHavuzu()
        {
            //5 çalışanla sınırlandırılıyır
            calisanList = new List<Calisan>();
            for (int i = 0; i < 5; i++)
            {

                calisanList.Add(new Calisan { Id = $"{i + 1} Id li calisan ", Durum = true });
            }
        }

    }
}
