namespace ComesticOhui.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreign_key : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Company_Id", c => c.Int());
            CreateIndex("dbo.Product", "Company_Id");
            AddForeignKey("dbo.Product", "Company_Id", "dbo.Company", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Company_Id", "dbo.Company");
            DropIndex("dbo.Product", new[] { "Company_Id" });
            DropColumn("dbo.Product", "Company_Id");
        }
    }
}
