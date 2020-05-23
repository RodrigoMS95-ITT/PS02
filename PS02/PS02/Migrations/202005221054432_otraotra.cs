namespace PS02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otraotra : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "Img", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "Img", c => c.Binary(nullable: false));
        }
    }
}
