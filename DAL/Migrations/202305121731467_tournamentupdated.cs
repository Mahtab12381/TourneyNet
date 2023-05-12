namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tournamentupdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tournaments", "Event_Id", "dbo.Events");
            DropIndex("dbo.Tournaments", new[] { "Event_Id" });
            RenameColumn(table: "dbo.Tournaments", name: "Event_Id", newName: "Event_event_id");
            AddColumn("dbo.Tournaments", "Prize", c => c.String());
            AddColumn("dbo.Tournaments", "Organizer_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Tournaments", "Event_event_id", c => c.Int());
            CreateIndex("dbo.Tournaments", "Organizer_Id");
            CreateIndex("dbo.Tournaments", "Event_event_id");
            AddForeignKey("dbo.Tournaments", "Organizer_Id", "dbo.Organizers", "Organizer_Id", cascadeDelete: true);
            AddForeignKey("dbo.Tournaments", "Event_event_id", "dbo.Events", "event_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tournaments", "Event_event_id", "dbo.Events");
            DropForeignKey("dbo.Tournaments", "Organizer_Id", "dbo.Organizers");
            DropIndex("dbo.Tournaments", new[] { "Event_event_id" });
            DropIndex("dbo.Tournaments", new[] { "Organizer_Id" });
            AlterColumn("dbo.Tournaments", "Event_event_id", c => c.Int(nullable: false));
            DropColumn("dbo.Tournaments", "Organizer_Id");
            DropColumn("dbo.Tournaments", "Prize");
            RenameColumn(table: "dbo.Tournaments", name: "Event_event_id", newName: "Event_Id");
            CreateIndex("dbo.Tournaments", "Event_Id");
            AddForeignKey("dbo.Tournaments", "Event_Id", "dbo.Events", "event_id", cascadeDelete: true);
        }
    }
}
