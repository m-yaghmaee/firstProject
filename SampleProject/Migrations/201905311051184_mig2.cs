namespace SampleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "CountryId", "dbo.Countries");
            DropIndex("dbo.Products", new[] { "CountryId" });
            AddColumn("dbo.Products", "CatehoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CatehoryId");
            AddForeignKey("dbo.Products", "CatehoryId", "dbo.Categories", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "CountryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CountryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "CatehoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CatehoryId" });
            DropColumn("dbo.Products", "CatehoryId");
            CreateIndex("dbo.Products", "CountryId");
            AddForeignKey("dbo.Products", "CountryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
    }
}
