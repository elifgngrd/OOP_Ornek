using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ornek
{
    class TcVatandas
    {
        public long TCKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime SistemeKayıtTarihi { get; set; }

        public TcVatandas()
        {
            SistemeKayıtTarihi = DateTime.Now;
        }
        public string VizeAl()
        {
            int yas = YasHesapla(DogumTarihi);
            if (yas>=18)
            {
                return "Başvurabilirsiniz";
            }
            else
            {
                return "Veli izni gerek";
            }
        }

        private int YasHesapla(DateTime dogumTarihi)
        {
            return DateTime.Today.Year- dogumTarihi.Year;
        }
    }
}
