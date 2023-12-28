using System;
using System.Data.Entity;

public class CreditCardDbContext : DbContext
{
	public DbSet<CreditCard> CreditCards { get; set; }

    public CreditCardDbContext() : base("name=dbconnection") { }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)

//    modelBuilder.Entity<CreditCard>(creditcard =>
//    {
//        creditcard.ToTable("CreditCard");
//        creditcard.HasKey(x => x.CardNumber);
//        creditcard.Property(x => x.Holder).IsRequired();
//        creditCard.Property(x => x.Balance).IsRequired();
//}); 
// Configuración de la clave primaria
    modelBuilder.Entity<CreditCard>().HasKey(c => c.CreditCardId);

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
    modelBuilder.Entity<CreditCard>().Property(c => c.IvaEnum)
                                      .IsRequired();

    base.OnModelCreating(modelBuilder);
    }
}
