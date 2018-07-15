namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNametoToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("INSERT INTO MembershipTypes (Name) VALUES (1, 0, 0, 0)");
            Sql("UPDATE Customers SET Name = 'Pay as You Go' WHERE CustomerID = 1; ");
            Sql("UPDATE Customers SET Name = 'Pay as You Go' WHERE CustomerID = 2; ");
            Sql("UPDATE Customers SET Name = 'Pay as You Go' WHERE CustomerID = 3; ");
            Sql("UPDATE Customers SET Name = 'Pay as You Go' WHERE CustomerID = 4; ");



        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
