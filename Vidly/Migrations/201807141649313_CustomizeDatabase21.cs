namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomizeDatabase21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Genre_Id1");
        }
        
        public override void Down()
        {
        }
    }
}
