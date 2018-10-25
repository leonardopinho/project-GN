namespace project_gn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanySize",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        id_company_size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CompanySize", t => t.id_company_size, cascadeDelete: true)
                .Index(t => t.id_company_size);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "id_company_size", "dbo.CompanySize");
            DropIndex("dbo.Customer", new[] { "id_company_size" });
            DropTable("dbo.Customer");
            DropTable("dbo.CompanySize");
        }
    }
}
