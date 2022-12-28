using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Db_Son_Hal.Entities
{
    public class Odeme
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public float ToplamTutar { get; set; }
        public float Bahsis { get; set; }
        public DateTime Tarih { get; set; }

        public int VeznedarId { get; set; }
        public Veznedar Veznedar { get; set; }
    }
}
