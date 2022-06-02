namespace WFGoodFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class burger1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Burgers", name: "Category_Id", newName: "CategoryId");
            RenameIndex(table: "dbo.Burgers", name: "IX_Category_Id", newName: "IX_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Burgers", name: "IX_CategoryId", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.Burgers", name: "CategoryId", newName: "Category_Id");
        }
    }
}
