namespace EasyRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentalsAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                        DateRented = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rentals");
        }
    }
}
