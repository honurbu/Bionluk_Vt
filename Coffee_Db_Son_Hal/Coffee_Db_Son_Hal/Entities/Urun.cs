using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Db_Son_Hal.Entities
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string UrunFiyati { get; set; }
        public string UrunAciklamasi { get; set; }
        public string UrunIcerigi { get; set; }


        public ICollection<Siparis> Siparisler { get; set; }
    }
}
