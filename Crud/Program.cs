using System;
using Infrastructure;

class Program
{
    static void Main()
    {
        using (var context = new CreditCardDbContext())
        {
            // Hacer algo con el DbContext, como migraciones o consultas
            Console.WriteLine("DbContext creado y conectado a la base de datos.");
        }
    }
}