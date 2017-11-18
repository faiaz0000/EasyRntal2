namespace EasyRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipvalues : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Name,DurationInmonths,SignUpFee,DiscountRate) VALUES ('Pay As You Go',0,0,0)");
            Sql("INSERT INTO MembershipTypes(Name,DurationInmonths,SignUpFee,DiscountRate) VALUES ('Monthly',1,30,10)");
            Sql("INSERT INTO MembershipTypes(Name,DurationInmonths,SignUpFee,DiscountRate) VALUES ('Quarterly',3,90,20)");
            Sql("INSERT INTO MembershipTypes(Name,DurationInmonths,SignUpFee,DiscountRate) VALUES ('Annually',12,200,40)");
        }
        
        public override void Down()
        {
        }
    }
}
