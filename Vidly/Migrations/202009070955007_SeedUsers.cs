namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3db520b4-9ee1-4ca4-aa13-e96f5b84eaa4', N'admin1@vidly.com', 0, N'APcosEa7G+qMX/0MFTihoyZDYRXh3niq0qmdK+bO2JTJIln8pKcaVTpWGtqiHRxOUA==', N'c911ac33-fb41-4c87-bfc9-3682cb26a63e', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5a3d1bcf-3cb0-4830-b6fa-b87b0bbf5539', N'admin@vidly.com', 0, N'AOXziv3HankPqDOuSQQeK94s/31IAl2PhIj7fqiayd/wzmWo/iLVbqz0ABneFYKDdg==', N'2289665d-8a9c-458a-bf3d-d2f221c15d3f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'747a02e1-de75-4c6c-8199-657a83a30bee', N'guest@vidly.com', 0, N'AFOlEs2TMJctHSzQfYzpe3IW8wfJTkqjfoNWHrLQw05G+jsF/pYayrE0U418ocRlXA==', N'bb2b108c-3e9e-4407-8f2f-f0e19f3e2dcf', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
