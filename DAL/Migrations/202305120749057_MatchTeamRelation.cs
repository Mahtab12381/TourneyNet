namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatchTeamRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "Team_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Matches", "Team_Id");
            AddForeignKey("dbo.Matches", "Team_Id", "dbo.Teams", "Team_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "Team_Id" });
            DropColumn("dbo.Matches", "Team_Id");
        }
    }
}
