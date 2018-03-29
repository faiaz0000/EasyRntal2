namespace EasyRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
           
            Sql(@"
                
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a4d992f5-bee3-4d9c-936f-40535ebcc9f8', N'admin@easyRental.com', 0, N'ADmnwFS/ZagEUQy4SrgccBlwg7Mu5vrFJXMF1E4wffdKn6sCA0IU1IgGMW9W8ELcCQ==', N'a9815abb-29d0-4163-ab94-bb58ebecc571', NULL, 0, 0, NULL, 1, 0, N'admin@easyRental.com')
                
                   INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58fab029-abea-4a7d-b6ce-b3f5df4e8541', N'MovieManager')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a4d992f5-bee3-4d9c-936f-40535ebcc9f8', N'58fab029-abea-4a7d-b6ce-b3f5df4e8541')

                ");
        }

    public override void Down()
        {
        }
    }
}
