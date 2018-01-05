namespace Vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatemovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Name) VALUES ('Action')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Comedy')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Sci-fi')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
