namespace SampleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersianName = c.String(maxLength: 4000),
                        EnglishName = c.String(maxLength: 4000),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        ModelName = c.String(maxLength: 4000),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .Index(t => t.CountryId)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Companies");
            DropForeignKey("dbo.Companies", "CountryId", "dbo.Countries");
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Products", new[] { "CountryId" });
            DropIndex("dbo.Companies", new[] { "CountryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Countries");
            DropTable("dbo.Companies");
            DropTable("dbo.Categories");
        }
    }
}
