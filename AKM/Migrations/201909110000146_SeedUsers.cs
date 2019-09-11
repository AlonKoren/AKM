namespace AKM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1d6acf85-81c6-4e00-8b89-b30d55495dac', N'Alon@AKM.com', 0, N'ALX+oI64pNMcQ/XVcG1eJnE1aR8+MiCbaH0xWIiRC7TeZb3S7SgGUjJSO9UCMm3qaQ==', N'34147a79-0cc0-4be0-b962-e86c68afbb9b', NULL, 0, 0, NULL, 1, 0, N'Alon@AKM.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c7f7b45f-4f43-4983-b2fd-18575b8010e6', N'guy_koren@gmail.com', 0, N'AFosMTzpijTBTvvW/jgLNKKGyqdSYOkdZgU5YNQ35K692Wm3XoS3Bx0wVkPU32eOqg==', N'36422ca5-d0b0-4c48-84e8-7383e1208bda', NULL, 0, 0, NULL, 1, 0, N'guy_koren@gmail.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'489755f0-52b9-4e09-a339-3f7404735ab2', N'CanManageMovies')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1d6acf85-81c6-4e00-8b89-b30d55495dac', N'489755f0-52b9-4e09-a339-3f7404735ab2')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
