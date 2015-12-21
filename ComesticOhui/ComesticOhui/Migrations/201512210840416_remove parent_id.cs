namespace ComesticOhui.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeparent_id : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Product", "Parent_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "Parent_Id", c => c.Int(nullable: false));
        }
    }
}
