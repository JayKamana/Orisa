namespace Orisa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.String());
        }
    }
}
