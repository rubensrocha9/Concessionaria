using Microsoft.EntityFrameworkCore;
using MonteSeuCarro.Automovel;
using MonteSeuCarro.Configuracoes_Databases;
using System.Configuration;

namespace MonteSeuCarro.Contexto
{
    public class ConcessionariaContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<AdicionaisCarro> Opcionais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Concessionaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False; ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .EnableSensitiveDataLogging().EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CarroConfiguration());
            modelBuilder.ApplyConfiguration(new AdicionaisCarroConfiguration());

        }
    }
}
