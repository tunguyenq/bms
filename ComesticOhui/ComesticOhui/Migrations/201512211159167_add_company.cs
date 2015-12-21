namespace ComesticOhui.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_company : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Slug = c.String(),
                        IsDeleted = c.String(),
                        State = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Company");
        }
    }
}
