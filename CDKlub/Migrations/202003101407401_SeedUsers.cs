namespace CDKlub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'07852f7a-262a-435d-8510-10574b6ea0d6', N'guest@cdklub.com', 0, N'AHc5faOfPXixlvlQKbzWL4YHlzAzAuvf1OYJeH1pX6rVdcM1suA9hxeVswHlowkTlA==', N'9f2d3f35-0055-4b65-97ae-025e86542986', NULL, 0, 0, NULL, 1, 0, N'guest@cdklub.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a22156c-29c1-4dbe-9988-08d6328e131e', N'admin@cdklub.com', 0, N'ADr8diyoXnSOYpvLli2Asqh4vIV5O2N5icPP+/ZqSnXeTYBO0wEBafv2/Xwvz4LmDA==', N'b38af61d-3ea6-49a1-9004-5801e1879ce1', NULL, 0, 0, NULL, 1, 0, N'admin@cdklub.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bb43e215-99a2-40d8-a372-8afdf225240c', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1a22156c-29c1-4dbe-9988-08d6328e131e', N'bb43e215-99a2-40d8-a372-8afdf225240c')

");
        }
        
        public override void Down()
        {
        }
    }
}
