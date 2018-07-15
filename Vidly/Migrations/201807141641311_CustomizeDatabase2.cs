namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomizeDatabase2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "Genre_Id1" });
            CreateIndex("dbo.Movies", "Genre_Id");
        }
        
        public override void Down()
        {
        }
    }
}
