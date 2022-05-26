﻿namespace WFGoodFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class toast : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Toasts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 255),
                        ImageUrl = c.String(maxLength: 255),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(maxLength: 2555),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Toasts", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Toasts", new[] { "Category_Id" });
            DropTable("dbo.Toasts");
        }
    }
}
