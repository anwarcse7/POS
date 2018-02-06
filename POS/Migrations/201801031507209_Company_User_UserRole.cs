namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Company_User_UserRole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CompanyCode = c.String(),
                        CompanyLogo = c.Binary(),
                        Phone = c.String(),
                        Mobile = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        CreatedUser = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditedUser = c.Guid(nullable: false),
                        EditedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Contact = c.String(maxLength: 20),
                        CreatedUser = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditedUser = c.Guid(nullable: false),
                        EditedDate = c.DateTime(nullable: false),
                        UserRoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserRole", t => t.UserRoleId, cascadeDelete: true)
                .Index(t => t.UserRoleId);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        UserRoleId = c.Int(nullable: false, identity: true),
                        UserRoleName = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreatedUser = c.Guid(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditedUser = c.Guid(nullable: false),
                        EditedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserRoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "UserRoleId", "dbo.UserRole");
            DropIndex("dbo.User", new[] { "UserRoleId" });
            DropTable("dbo.UserRole");
            DropTable("dbo.User");
            DropTable("dbo.Company");
        }
    }
}
