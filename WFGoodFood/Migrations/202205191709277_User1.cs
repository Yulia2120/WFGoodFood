namespace WFGoodFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 255));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
        }
    }
}
