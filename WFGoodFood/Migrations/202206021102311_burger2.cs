namespace WFGoodFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class burger2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Quantity = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            AddColumn("dbo.Burgers", "OrderId", c => c.Int());
            CreateIndex("dbo.Burgers", "OrderId");
            AddForeignKey("dbo.Burgers", "OrderId", "dbo.Orders", "OrderId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Burgers", "OrderId", "dbo.Orders");
            DropIndex("dbo.Burgers", new[] { "OrderId" });
            DropColumn("dbo.Burgers", "OrderId");
            DropTable("dbo.Orders");
        }
    }
}
