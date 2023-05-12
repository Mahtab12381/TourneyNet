namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Match_id = c.Int(nullable: false, identity: true),
                        Tournament_id = c.Int(nullable: false),
                        Match_number = c.Int(nullable: false),
                        Match_start_time = c.DateTime(nullable: false),
                        Match_end_time = c.DateTime(nullable: false),
                        Match_winner_team_id = c.Int(nullable: false),
                        Match_loser_team_id = c.Int(nullable: false),
                        w_score = c.Int(nullable: false),
                        l_score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Match_id);
            
            CreateTable(
                "dbo.TeamCommunications",
                c => new
                    {
                        Communication_id = c.Int(nullable: false, identity: true),
                        Team_id = c.Int(nullable: false),
                        Sender_id = c.Int(nullable: false),
                        Receiver_id = c.Int(nullable: false),
                        Message = c.String(),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Communication_id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Team_id = c.Int(nullable: false, identity: true),
                        Team_name = c.String(nullable: false),
                        Team_logo = c.String(nullable: false),
                        Captain_id = c.Int(nullable: false),
                        Player2_id = c.Int(nullable: false),
                        Player3_id = c.Int(nullable: false),
                        Player4_id = c.Int(nullable: false),
                        Player5_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Team_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.TeamCommunications");
            DropTable("dbo.Matches");
        }
    }
}
