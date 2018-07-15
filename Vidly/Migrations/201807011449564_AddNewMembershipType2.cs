namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewMembershipType2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Mounthly' WHERE id = 2; ");
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE id = 3; ");
            Sql("UPDATE MembershipTypes SET Name = 'Mounthly' WHERE id = 4; ");
            Sql("UPDATE Customers SET Name = 'Mary Williams' WHERE id = 2; ");


        }

        public override void Down()
        {
        }
    }
}
