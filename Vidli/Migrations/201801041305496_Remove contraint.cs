namespace Vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removecontraint : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE MOVIES DROP CONSTRAINT DF__Movies__Genre__3C69FB99");
            AlterColumn("dbo.Movies", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.Int(nullable: false));
        }
    }
}
