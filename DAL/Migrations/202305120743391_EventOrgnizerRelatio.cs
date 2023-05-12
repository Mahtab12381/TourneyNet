namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventOrgnizerRelatio : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Events", "Organizer_Id");
            AddForeignKey("dbo.Events", "Organizer_Id", "dbo.Organizers", "Organizer_Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Organizer_Id", "dbo.Organizers");
            DropIndex("dbo.Events", new[] { "Organizer_Id" });
        }
    }
}
