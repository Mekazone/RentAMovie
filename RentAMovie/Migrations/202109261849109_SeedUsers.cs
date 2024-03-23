namespace RentAMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd57ffd3a-cc85-4328-b223-459807eba2cf', N'admin@yahoo.com', 0, N'AHi8frNFYCucUvLwb3OoRrS+CkMymXjb3t5yHGCR+qmSZ3af3gJJr2tMnCpnhVQVpQ==', N'98dd5fb8-f2c0-407e-9daa-e834d9e31c9b', NULL, 0, 0, NULL, 1, 0, N'admin@yahoo.com')");
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b7c68432-043f-4231-b4a2-83b10eca039d', N'CanManageMovies')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd57ffd3a-cc85-4328-b223-459807eba2cf', N'b7c68432-043f-4231-b4a2-83b10eca039d')");
        }
        
        public override void Down()
        {
        }
    }
}
