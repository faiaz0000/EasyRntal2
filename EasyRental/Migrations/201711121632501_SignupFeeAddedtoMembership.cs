namespace EasyRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SignupFeeAddedtoMembership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUnpFee", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "SignUnpFee");
        }
    }
}
