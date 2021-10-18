using Microsoft.EntityFrameworkCore;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Municipio> Municipio{get; set;}
        public DbSet<DirectorTecnico> DirectorTecnico{get; set;}
        public DbSet<Equipo> Equipo{get; set;}
        public DbSet<Arbitro> Arbitro{get; set;}
        public DbSet<Desempeño> Desempeño{get; set;}
        public DbSet<Estadio> Estadio{get; set;}
        public DbSet<Jugador> Jugador{get; set;}
        public DbSet<MarcadorFinal> MarcadorFinal{get; set;}
        public DbSet<Novedad> Novedad{get; set;}
        public DbSet<Partido> Partido{get; set;}
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=TorneoDeFutbolData");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder){
           builder.Entity<Equipo>().HasIndex(e=>e.DirectorTecnicoId).IsUnique();
           builder.Entity<Equipo>().HasIndex(e=>e.MunicipioId).IsUnique();
            

       }

    }
}

