namespace asp_hw10_js.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        EmploymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employments", t => t.EmploymentId, cascadeDelete: true)
                .Index(t => t.EmploymentId);
            
            CreateTable(
                "dbo.Employments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "EmploymentId", "dbo.Employments");
            DropIndex("dbo.Customers", new[] { "EmploymentId" });
            DropTable("dbo.Employments");
            DropTable("dbo.Customers");
        }
    }
}
