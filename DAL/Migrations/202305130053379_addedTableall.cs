namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTableall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FanPosts",
                c => new
                    {
                        FanPost_id = c.Int(nullable: false, identity: true),
                        PostContent = c.String(),
                        PostDate = c.DateTime(nullable: false),
                        Posted_by_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FanPost_id)
                .ForeignKey("dbo.Registrations", t => t.Posted_by_Id, cascadeDelete: true)
                .Index(t => t.Posted_by_Id);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Bio = c.String(nullable: false),
                        ContactInformation = c.String(nullable: false),
                        Fan_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registrations", t => t.Fan_Id, cascadeDelete: true)
                .Index(t => t.Fan_Id);
            
            CreateTable(
                "dbo.Organizers",
                c => new
                    {
                        Organizer_Id = c.Int(nullable: false, identity: true),
                        Organizer_Description = c.String(nullable: false),
                        Organizer_reg_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Organizer_Id)
                .ForeignKey("dbo.Registrations", t => t.Organizer_reg_id, cascadeDelete: true)
                .Index(t => t.Organizer_reg_id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        tournament_id = c.Int(nullable: false, identity: true),
                        tournament_name = c.String(),
                        tournament_description = c.String(),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        registration_deadline = c.DateTime(nullable: false),
                        tournament_rules = c.String(),
                        Prize = c.String(),
                        Organizer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.tournament_id)
                .ForeignKey("dbo.Registrations", t => t.Organizer_Id, cascadeDelete: true)
                //.ForeignKey("dbo.Organizers", t => t.Organizer_Id, cascadeDelete: true)
                .Index(t => t.Organizer_Id);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Match_id = c.Int(nullable: false, identity: true),
                        Match_number = c.Int(nullable: false),
                        Match_start_time = c.DateTime(nullable: false),
                        Match_end_time = c.DateTime(nullable: false),
                        Match_winner_team_id = c.Int(),
                        Match_loser_team_id = c.Int(),
                        w_score = c.Int(nullable: false),
                        l_score = c.Int(nullable: false),
                        participant_Id1 = c.Int(),
                        participant_Id2 = c.Int(),
                        Tournament_id = c.Int(nullable: false),
                        Participant_participant_id = c.Int(),
                    })
                .PrimaryKey(t => t.Match_id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_id, cascadeDelete: true)
                .ForeignKey("dbo.Participants", t => t.Participant_participant_id)
                .Index(t => t.Tournament_id)
                .Index(t => t.Participant_participant_id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        participant_id = c.Int(nullable: false, identity: true),
                        team_name = c.String(),
                        team_logo = c.String(),
                        team_id = c.Int(nullable: false),
                        Tournament_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.participant_id)
                .ForeignKey("dbo.Teams", t => t.team_id, cascadeDelete: true)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_id, cascadeDelete: true)
                .Index(t => t.team_id)
                .Index(t => t.Tournament_id);
            
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
            
            CreateTable(
                "dbo.TeamCommunications",
                c => new
                    {
                        Communication_id = c.Int(nullable: false, identity: true),
                        Sender_id = c.Int(nullable: false),
                        Receiver_id = c.Int(nullable: false),
                        Message = c.String(),
                        Timestamp = c.DateTime(nullable: false),
                        Team_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Communication_id)
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Rankings",
                c => new
                    {
                        ranking_id = c.Int(nullable: false, identity: true),
                        rank = c.Int(nullable: false),
                        participant_id = c.Int(nullable: false),
                        tournament_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ranking_id)
                .ForeignKey("dbo.Participants", t => t.participant_id, cascadeDelete: true)
                .ForeignKey("dbo.Tournaments", t => t.tournament_id, cascadeDelete: false)
                .Index(t => t.participant_id)
                .Index(t => t.tournament_id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        player_Id = c.Int(nullable: false, identity: true),
                        gender = c.String(),
                        nationality = c.String(),
                        age = c.Int(nullable: false),
                        player_reg_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.player_Id)
                .ForeignKey("dbo.Registrations", t => t.player_reg_id, cascadeDelete: true)
                .Index(t => t.player_reg_id);
            
            CreateTable(
                "dbo.PlayerGames",
                c => new
                    {
                        Player_Game_Id = c.Int(nullable: false, identity: true),
                        Game_Name = c.String(nullable: false),
                        Player_Skill = c.String(),
                        Player_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Player_Game_Id)
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .Index(t => t.Player_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        payment_id = c.Int(nullable: false, identity: true),
                        amount_paid = c.Single(nullable: false),
                        payment_date = c.DateTime(nullable: false),
                        participant_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.payment_id)
                .ForeignKey("dbo.Participants", t => t.participant_id, cascadeDelete: true)
                .Index(t => t.participant_id);
            
            CreateTable(
                "dbo.SocialMediaSharings",
                c => new
                    {
                        share_id = c.Int(nullable: false, identity: true),
                        share_date = c.DateTime(nullable: false),
                        platform = c.String(),
                        share_description = c.String(),
                    })
                .PrimaryKey(t => t.share_id);
            
            CreateTable(
                "dbo.Streams",
                c => new
                    {
                        Stream_id = c.Int(nullable: false, identity: true),
                        Stream_link = c.String(nullable: false),
                        Stream_description = c.String(),
                    })
                .PrimaryKey(t => t.Stream_id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        token_id = c.Int(nullable: false, identity: true),
                        Token_key = c.String(nullable: false),
                        Created_at = c.DateTime(nullable: false),
                        deleted_at = c.DateTime(),
                        User_id = c.String(nullable: false),
                        Type = c.String(),
                        reg_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.token_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "participant_id", "dbo.Participants");
            DropForeignKey("dbo.FanPosts", "Posted_by_Id", "dbo.Registrations");
            DropForeignKey("dbo.Players", "player_reg_id", "dbo.Registrations");
            DropForeignKey("dbo.PlayerGames", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Tournaments", "Organizer_Id", "dbo.Organizers");
            DropForeignKey("dbo.Tournaments", "Organizer_Id", "dbo.Registrations");
            DropForeignKey("dbo.Rankings", "tournament_id", "dbo.Tournaments");
            DropForeignKey("dbo.Rankings", "participant_id", "dbo.Participants");
            DropForeignKey("dbo.Participants", "Tournament_id", "dbo.Tournaments");
            DropForeignKey("dbo.Participants", "team_id", "dbo.Teams");
            DropForeignKey("dbo.TeamCommunications", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Participant_participant_id", "dbo.Participants");
            DropForeignKey("dbo.Matches", "Tournament_id", "dbo.Tournaments");
            DropForeignKey("dbo.Organizers", "Organizer_reg_id", "dbo.Registrations");
            DropForeignKey("dbo.Fans", "Fan_Id", "dbo.Registrations");
            DropIndex("dbo.Payments", new[] { "participant_id" });
            DropIndex("dbo.PlayerGames", new[] { "Player_Id" });
            DropIndex("dbo.Players", new[] { "player_reg_id" });
            DropIndex("dbo.Rankings", new[] { "tournament_id" });
            DropIndex("dbo.Rankings", new[] { "participant_id" });
            DropIndex("dbo.TeamCommunications", new[] { "Team_Id" });
            DropIndex("dbo.Participants", new[] { "Tournament_id" });
            DropIndex("dbo.Participants", new[] { "team_id" });
            DropIndex("dbo.Matches", new[] { "Participant_participant_id" });
            DropIndex("dbo.Matches", new[] { "Tournament_id" });
            DropIndex("dbo.Tournaments", new[] { "Organizer_Id" });
            DropIndex("dbo.Organizers", new[] { "Organizer_reg_id" });
            DropIndex("dbo.Fans", new[] { "Fan_Id" });
            DropIndex("dbo.FanPosts", new[] { "Posted_by_Id" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Streams");
            DropTable("dbo.SocialMediaSharings");
            DropTable("dbo.Payments");
            DropTable("dbo.PlayerGames");
            DropTable("dbo.Players");
            DropTable("dbo.Rankings");
            DropTable("dbo.TeamCommunications");
            DropTable("dbo.Teams");
            DropTable("dbo.Participants");
            DropTable("dbo.Matches");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Organizers");
            DropTable("dbo.Fans");
            DropTable("dbo.Registrations");
            DropTable("dbo.FanPosts");
        }
    }
}
