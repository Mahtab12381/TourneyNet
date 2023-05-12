namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventRelation : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Streams", "event_id");
            AddForeignKey("dbo.Streams", "event_id", "dbo.Events", "event_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Streams", "event_id", "dbo.Events");
            DropIndex("dbo.Streams", new[] { "event_id" });
        }
    }
}
