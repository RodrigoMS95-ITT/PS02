namespace PS02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reportes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cliente = c.String(nullable: false),
                        Orden = c.String(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estatus = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reportes");
        }
    }
}
