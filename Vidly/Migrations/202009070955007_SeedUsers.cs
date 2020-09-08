namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4b3fbeaa-531b-4e90-a805-b552f4bc1250', N'guest@vidly.com', 0, N'AN1TKkNNfEUKSFH0HEUynN1Ed8Oeuh4LuBX2nF/HPIivmvXvCHvHkxJHzHOIlevExw==', N'2098e015-6ef5-48fd-815a-18720663853e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bad5e83d-ce6f-4ee1-9c8a-d86785f6d90d', N'admin@vidly.com', 0, N'AP84N/9SGziCGXn0t7TClyfIp8FN/CAVvTZSZ1r39HKH/A6SGKgAsIJhb8P7NhNM8g==', N'7e4fb2ad-9450-41d1-a3fc-b16d101cf1ee', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'01eeec80-a08a-472c-ac3d-cefbf1ad9a67', N'CanManageMovies')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
