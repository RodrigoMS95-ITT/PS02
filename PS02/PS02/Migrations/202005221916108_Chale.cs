namespace PS02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chale : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reportes", "Cantidad", c => c.Int(nullable: false));
            AddColumn("dbo.Reportes", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Reportes", "MenuID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reportes", "MenuID");
            AddForeignKey("dbo.Reportes", "MenuID", "dbo.Menus", "ID", cascadeDelete: true);
            DropColumn("dbo.Reportes", "Orden");
            DropColumn("dbo.Reportes", "Precio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reportes", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Reportes", "Orden", c => c.String(nullable: false));
            DropForeignKey("dbo.Reportes", "MenuID", "dbo.Menus");
            DropIndex("dbo.Reportes", new[] { "MenuID" });
            DropColumn("dbo.Reportes", "MenuID");
            DropColumn("dbo.Reportes", "Total");
            DropColumn("dbo.Reportes", "Cantidad");
        }
    }
}
