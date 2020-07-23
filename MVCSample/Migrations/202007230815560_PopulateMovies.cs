namespace MVCSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("Insert into Movies(Id,Name,GenreId) values (1,'Hangover',2)");
            Sql("Insert into Movies(Id,Name,GenreId) values (2,'Die Hard',1)");
            Sql("Insert into Movies(Id,Name,GenreId) values (3,'The Terminator',1)");
            Sql("Insert into Movies(Id,Name,GenreId) values (4,'Toy Story',3)");
            Sql("Insert into Movies(Id,Name,GenreId) values (5,'Titanic',4)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
