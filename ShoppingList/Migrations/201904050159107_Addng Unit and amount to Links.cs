namespace ShoppingList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddngUnitandamounttoLinks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ingredient_Recipe_Link", "Unit", c => c.Int(nullable: false));
            AddColumn("dbo.Ingredient_Recipe_Link", "Amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ingredient_Recipe_Link", "Amount");
            DropColumn("dbo.Ingredient_Recipe_Link", "Unit");
        }
    }
}
