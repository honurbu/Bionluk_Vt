using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Db_Son_Hal.Entities
{
    public class Garson
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNumarasi { get; set; }


        public Magaza Magaza { get; set; }
        public ICollection<Siparis> Siparisler { get; set; }
    }
}
