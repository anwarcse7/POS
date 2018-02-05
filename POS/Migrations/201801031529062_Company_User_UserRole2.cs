namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Company_User_UserRole2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Company", "CompanyName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Company", "CreatedUser", c => c.Guid());
            AlterColumn("dbo.Company", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.Company", "EditedUser", c => c.Guid());
            AlterColumn("dbo.Company", "EditedDate", c => c.DateTime());
            AlterColumn("dbo.User", "CreatedUser", c => c.Guid());
            AlterColumn("dbo.User", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.User", "EditedUser", c => c.Guid());
            AlterColumn("dbo.User", "EditedDate", c => c.DateTime());
            AlterColumn("dbo.UserRole", "UserRoleName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.UserRole", "CreatedUser", c => c.Guid());
            AlterColumn("dbo.UserRole", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.UserRole", "EditedUser", c => c.Guid());
            AlterColumn("dbo.UserRole", "EditedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserRole", "EditedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserRole", "EditedUser", c => c.Guid(nullable: false));
            AlterColumn("dbo.UserRole", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserRole", "CreatedUser", c => c.Guid(nullable: false));
            AlterColumn("dbo.UserRole", "UserRoleName", c => c.String());
            AlterColumn("dbo.User", "EditedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.User", "EditedUser", c => c.Guid(nullable: false));
            AlterColumn("dbo.User", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.User", "CreatedUser", c => c.Guid(nullable: false));
            AlterColumn("dbo.Company", "EditedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Company", "EditedUser", c => c.Guid(nullable: false));
            AlterColumn("dbo.Company", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Company", "CreatedUser", c => c.Guid(nullable: false));
            AlterColumn("dbo.Company", "CompanyName", c => c.String());
        }
    }
}
