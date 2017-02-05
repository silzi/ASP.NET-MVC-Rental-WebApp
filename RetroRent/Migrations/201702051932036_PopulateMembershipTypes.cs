namespace RetroRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql ("INSERT INTO MembershipTypes (Id, SingUpFee, Duration, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql ("INSERT INTO MembershipTypes (Id, SingUpFee, Duration, DiscountRate) VALUES (2, 10, 1, 10)");
            Sql ("INSERT INTO MembershipTypes (Id, SingUpFee, Duration, DiscountRate) VALUES (3, 20, 3, 15)");
            Sql ("INSERT INTO MembershipTypes (Id, SingUpFee, Duration, DiscountRate) VALUES (4, 50, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
