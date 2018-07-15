namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre_Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Genre_Name");
        }
    }
}
