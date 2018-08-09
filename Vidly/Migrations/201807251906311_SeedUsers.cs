namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'72a4be9f-9d88-4df0-b8e9-48f557beafd7', N'admin@vidly.com', 0, N'AO09SaHAKG4v/jfZzLIHmpwcbBNLwHOts5AD8fXryVoH6ApVY8cI2OdrP3kXOjBH3Q==', N'6c461eaa-7031-40a3-aca7-01feea4483c3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fd0c3034-eb90-4c56-ae07-790bee19a9d9', N'guest@vidly.com', 0, N'AOl5Bs7NGo8A1s17Oy+6Rmy0cmugKrMuKliOrSL/egYTrso7MlP1o10kNam07TFJog==', N'd0b34d6c-15f9-4a65-ae28-7ac3572ac4eb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ff62940b-f767-4b96-ae2e-bd2935af9f28', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'72a4be9f-9d88-4df0-b8e9-48f557beafd7', N'ff62940b-f767-4b96-ae2e-bd2935af9f28')
");
        }
        
        public override void Down()
        {
        }
    }
}
