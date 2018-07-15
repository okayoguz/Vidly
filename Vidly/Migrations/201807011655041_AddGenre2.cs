namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Genre_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre_Name", c => c.String());
        }
    }
}
