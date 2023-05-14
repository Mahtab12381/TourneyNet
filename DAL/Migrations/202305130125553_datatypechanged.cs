namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datatypechanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "Match_winner_Name", c => c.String());
            AddColumn("dbo.Matches", "Match_loser_Name", c => c.String());
            AddColumn("dbo.Matches", "participant_name_1", c => c.String());
            AddColumn("dbo.Matches", "participant_name_2", c => c.String());
            DropColumn("dbo.Matches", "Match_winner_team_id");
            DropColumn("dbo.Matches", "Match_loser_team_id");
            DropColumn("dbo.Matches", "participant_Id1");
            DropColumn("dbo.Matches", "participant_Id2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "participant_Id2", c => c.Int());
            AddColumn("dbo.Matches", "participant_Id1", c => c.Int());
            AddColumn("dbo.Matches", "Match_loser_team_id", c => c.Int());
            AddColumn("dbo.Matches", "Match_winner_team_id", c => c.Int());
            DropColumn("dbo.Matches", "participant_name_2");
            DropColumn("dbo.Matches", "participant_name_1");
            DropColumn("dbo.Matches", "Match_loser_Name");
            DropColumn("dbo.Matches", "Match_winner_Name");
        }
    }
}
