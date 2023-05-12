namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventRelation12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tournaments", "Event_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Tournaments", "Event_Id");
            AddForeignKey("dbo.Tournaments", "Event_Id", "dbo.Events", "event_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tournaments", "Event_Id", "dbo.Events");
            DropIndex("dbo.Tournaments", new[] { "Event_Id" });
            DropColumn("dbo.Tournaments", "Event_Id");
        }
    }
}
