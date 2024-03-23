namespace RentAMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes VALUES (1,'Pay as You Go',0,0,0)");
            Sql("INSERT INTO MembershipTypes VALUES (2,'Monthly',30,1,10)");
            Sql("INSERT INTO MembershipTypes VALUES (3,'Quarterly',90,3,15)");
            Sql("INSERT INTO MembershipTypes VALUES (4,'Annually',300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
