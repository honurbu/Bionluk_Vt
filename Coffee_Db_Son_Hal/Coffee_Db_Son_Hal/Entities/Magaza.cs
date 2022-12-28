using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Db_Son_Hal.Entities
{
    public class Magaza
    {
        public int Id { get; set; }
        public string TelefonNumarasi { get; set; }
        public int AdresId { get; set; }

        public ICollection<Garson> Garsonlar { get; set; }
        public ICollection<Veznedar> Veznedarlar { get; set; }

    }
}
