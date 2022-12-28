using Coffee_Db_Son_Hal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Db_Son_Hal
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost; Database=KahveDbBionlukSon; Trusted_Connection=SSPI; Encrypt=false; TrustServerCertificate=true");
        }



        public DbSet<Magaza> Magazalar { get; set; }
        public DbSet<Garson> Garsons { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Veznedar> Veznedarlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }
    }
}
