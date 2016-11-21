using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PregledPrograma.DB
{
    public class BazaContext : DbContext
    {
        public BazaContext() : base("PregledKonekcija")
        {

        }

        public DbSet<Kosuljica> Kosuljice { get; set; }
        public DbSet<Zanr> Zanrovi { get; set; }
        public DbSet<TipEmitovanja> TipoviEmitovanja { get; set; }
        public DbSet<Redakcija> Redakcije { get; set; }
        public DbSet<Rejting> Rejtinzi { get; set; }
        public DbSet<Parametar> Parametri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
