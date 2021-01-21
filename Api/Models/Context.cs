using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Utils;

namespace Api.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public virtual DbSet<Abonos> Abonos { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Carreras> Carreras { get; set; }
        public virtual DbSet<Conductores> Conductores { get; set; }
        public virtual DbSet<Creditos> Creditos { get; set; }
        public virtual DbSet<DetallesDeCreditos> DetallesDeCreditos { get; set; }
        public virtual DbSet<LugaresFinalesDelosRecorridos> LugaresFinalesDelosRecorridos { get; set; }
        public virtual DbSet<Penalizaciones> Penalizaciones { get; set; }
        public virtual DbSet<Socios> Socios { get; set; }
        public virtual DbSet<Turnos> Turnos { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralization();
            modelBuilder.SetDecimalPrecision();
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
