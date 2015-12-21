namespace ComesticOhui.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category_Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Slug = c.String(),
                        Tax_Type = c.String(),
                        Date_Add = c.DateTime(nullable: false),
                        Date_modified = c.DateTime(nullable: false),
                        IsDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Parent_Id = c.Int(nullable: false),
                        Post_type = c.String(),
                        Slug = c.String(),
                        Post_date = c.DateTime(nullable: false),
                        Title = c.String(),
                        Excerpt = c.String(),
                        Post_Status = c.String(),
                        Name = c.String(),
                        Post_Modifield = c.DateTime(nullable: false),
                        IsDeleted = c.Int(nullable: false),
                        Author = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Category_Product", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Category_Product", "CategoryId", "dbo.Category");
            DropIndex("dbo.Category_Product", new[] { "CategoryId" });
            DropIndex("dbo.Category_Product", new[] { "ProductId" });
            DropTable("dbo.Product");
            DropTable("dbo.Category");
            DropTable("dbo.Category_Product");
        }
    }
}
