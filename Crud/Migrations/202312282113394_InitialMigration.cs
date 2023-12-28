namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        CardNumber = c.String(nullable: false, maxLength: 16),
                        Id = c.Int(nullable: false),
                        Holder = c.String(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CardNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CreditCards");
        }
    }
}
