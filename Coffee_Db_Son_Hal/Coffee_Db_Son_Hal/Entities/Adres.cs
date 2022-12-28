using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Db_Son_Hal.Entities
{
    public class Adres
    {
        public int Id { get; set; }
        public string Mahalle { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
    }
}
