namespace EasyRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Movies", "AvilableInStcock", c => c.Int(nullable: false));
        }
    }
}
