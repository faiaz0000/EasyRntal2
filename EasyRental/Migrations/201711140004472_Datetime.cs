namespace EasyRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Datetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "DateofBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DateofBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
