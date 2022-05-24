namespace WFGoodFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Phone", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Phone");
        }
    }
}
