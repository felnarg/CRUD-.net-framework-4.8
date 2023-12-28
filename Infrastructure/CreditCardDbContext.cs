using System.Data.Entity;
using Domain.Models;

namespace Infrastructure
{
    public class CreditCardDbContext : DbContext
    {
        public DbSet<CreditCard> CreditCards { get; set; }

        public CreditCardDbContext() : base("name=DefaultConnection") { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditCard>().HasKey(c => c.CardNumber);

            // Configuración de la longitud máxima del número de tarjeta
            modelBuilder.Entity<CreditCard>().Property(c => c.CardNumber)
                                              .HasMaxLength(16);

            // Configuración de propiedades requeridas
            modelBuilder.Entity<CreditCard>().Property(c => c.CardNumber)
                                              .IsRequired();
            modelBuilder.Entity<CreditCard>().Property(c => c.Holder)
                                              .IsRequired();
            modelBuilder.Entity<CreditCard>().Property(c => c.Balance)
                                              .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}