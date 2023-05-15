namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teamCommunication : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TeamCommunications", "Message", c => c.String(nullable: false));
            DropColumn("dbo.TeamCommunications", "Receiver_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamCommunications", "Receiver_id", c => c.Int(nullable: false));
            AlterColumn("dbo.TeamCommunications", "Message", c => c.String());
        }
    }
}
