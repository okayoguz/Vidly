namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberinStock, Genre_Id) VALUES ('Hangover', 06/11/2009, 04/05/2016, 5, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberinStock, Genre_Id) VALUES ('Die Hard', 06/11/1988, 04/05/2016, 6, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberinStock, Genre_Id) VALUES ('The Terminator', 06/11/1984, 04/05/2016, 7, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberinStock, Genre_Id) VALUES ('Toy Story', 06/11/1995, 04/05/2016, 8, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberinStock, Genre_Id) VALUES ('Titanic', 06/11/1997, 04/05/2016, 9, 4)");
                                     
        }

        public override void Down()
        {
        }
    }
}
