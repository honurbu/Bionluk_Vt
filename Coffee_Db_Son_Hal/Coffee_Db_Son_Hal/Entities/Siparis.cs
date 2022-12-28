using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Db_Son_Hal.Entities
{
    public class Siparis
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public string Aciklama { get; set; }
        public DateTime SiparisTarihi { get; set; }


        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        public int GarsonId { get; set; }
        public Garson Garson { get; set; }

        public ICollection<Urun> Urunler { get; set; }
    }
}
