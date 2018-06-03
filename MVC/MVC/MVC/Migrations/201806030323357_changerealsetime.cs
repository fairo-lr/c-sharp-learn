namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changerealsetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "ReleaseTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "ReleaseTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
