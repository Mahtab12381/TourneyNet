namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RangkingTournamentUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rankings", "Tournament_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rankings", "Tournament_Id");
            AddForeignKey("dbo.Rankings", "Tournament_Id", "dbo.Tournaments", "tournament_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rankings", "Tournament_Id", "dbo.Tournaments");
            DropIndex("dbo.Rankings", new[] { "Tournament_Id" });
            DropColumn("dbo.Rankings", "Tournament_Id");
        }
    }
}
