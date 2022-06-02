namespace WFGoodFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class order : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "CustomerId", c => c.String(maxLength: 255));
            AlterColumn("dbo.Orders", "Phone", c => c.String(maxLength: 255));
            AlterColumn("dbo.Orders", "Address", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Address", c => c.String());
            AlterColumn("dbo.Orders", "Phone", c => c.String());
            AlterColumn("dbo.Orders", "CustomerId", c => c.String());
        }
    }
}
