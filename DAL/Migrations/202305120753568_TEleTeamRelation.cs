namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TEleTeamRelation : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.TeamCommunications", "Team_Id");
            AddForeignKey("dbo.TeamCommunications", "Team_Id", "dbo.Teams", "Team_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamCommunications", "Team_Id", "dbo.Teams");
            DropIndex("dbo.TeamCommunications", new[] { "Team_Id" });
        }
    }
}
