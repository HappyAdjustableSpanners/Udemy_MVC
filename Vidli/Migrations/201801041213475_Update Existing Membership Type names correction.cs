namespace Vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingMembershipTypenamescorrection : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
