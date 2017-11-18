namespace EasyRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "SignUnpFee");
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "SignUnpFee", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
