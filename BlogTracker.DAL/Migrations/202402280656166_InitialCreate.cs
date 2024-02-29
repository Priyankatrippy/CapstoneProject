namespace BlogTracker.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminInfoes",
                c => new
                    {
                        AdminInfoId = c.Int(nullable: false, identity: true),
                        EmailId = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminInfoId);
            
            CreateTable(
                "dbo.BlogInfoes",
                c => new
                    {
                        BlogInfoId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Subject = c.String(),
                        DateOfCreation = c.DateTime(nullable: false),
                        BlogUrl = c.String(),
                        EmpEmailId = c.String(),
                    })
                .PrimaryKey(t => t.BlogInfoId);
            
            CreateTable(
                "dbo.EmpInfoes",
                c => new
                    {
                        EmpInfoId = c.Int(nullable: false, identity: true),
                        EmailId = c.String(),
                        Name = c.String(),
                        DateOfJoining = c.DateTime(nullable: false),
                        PassCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpInfoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmpInfoes");
            DropTable("dbo.BlogInfoes");
            DropTable("dbo.AdminInfoes");
        }
    }
}
