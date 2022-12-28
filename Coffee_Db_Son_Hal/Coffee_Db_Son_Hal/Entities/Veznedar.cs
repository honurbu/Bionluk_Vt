using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Db_Son_Hal.Entities
{
    public class Veznedar
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int AdresId { get; set; }

        public int MagazaId { get; set; }
        public Magaza Magaza { get; set; }


        public ICollection<Odeme> Odemeler { get; set; }
    }
}
