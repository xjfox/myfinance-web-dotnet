using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Entities;

namespace myfinance_web_netcore
{
    public class MyFinanceDbContext : DbContext
    {
        public DbSet<PlanoConta> PlanoConta { get; set; }
        public DbSet<Transacao> Transacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DotNetEnv.Env.Load("Config/database.env");
            var server = System.Environment.GetEnvironmentVariable("SERVER");
            var database = System.Environment.GetEnvironmentVariable("DATABASE");
            var connectionString = @"Server=" + server + "\\SQLEXPRESS;Database=" + database + ";Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transacao>()
                .ToTable("Transacao")
                .Property(x => x.PlanoContaId)
                .HasColumnName("PlanoConta_Id");
        }
    }
}