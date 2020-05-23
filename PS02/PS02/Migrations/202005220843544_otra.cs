namespace PS02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otra : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Img", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "Img");
        }
    }
}
