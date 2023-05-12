namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TournanmentRelation : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Participants", "Tournament_id");
            AddForeignKey("dbo.Participants", "Tournament_id", "dbo.Tournaments", "tournament_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participants", "Tournament_id", "dbo.Tournaments");
            DropIndex("dbo.Participants", new[] { "Tournament_id" });
        }
    }
}
