namespace MVCSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatechnges3 : DbMigration
    {
        public override void Up()

        {
            Sql("ALTER TABLE Movies DROP CONSTRAINT FK_dbo.Movies_dbo.Genres_Genre_Id");
            Sql("ALTER TABLE Movies DROP column Genre_Id");
        }
        
        public override void Down()
        {
        }
    }
}
