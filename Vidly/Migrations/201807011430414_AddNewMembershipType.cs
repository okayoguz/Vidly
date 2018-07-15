namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE id = 1; ");
            Sql("UPDATE MembershipTypes SET Name = 'Mounthly' WHERE id = 2; ");
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE id = 3; ");
            Sql("UPDATE MembershipTypes SET Name = 'Mounthly' WHERE id = 4; ");
        }
        
        public override void Down()
        {
        }
    }
}
