namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventRelationwithSocial : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SocialMediaSharings", "Event_Id");
            AddForeignKey("dbo.SocialMediaSharings", "Event_Id", "dbo.Events", "event_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialMediaSharings", "Event_Id", "dbo.Events");
            DropIndex("dbo.SocialMediaSharings", new[] { "Event_Id" });
        }
    }
}
