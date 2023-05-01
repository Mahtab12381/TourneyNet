namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class even_part_sms_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        event_id = c.Int(nullable: false, identity: true),
                        organizer_id = c.Int(nullable: false),
                        event_name = c.String(),
                        event_description = c.String(),
                        event_start_date = c.DateTime(nullable: false),
                        event_end_date = c.DateTime(nullable: false),
                        location = c.String(),
                        rules = c.String(),
                        prizes = c.String(),
                        registration_deadline = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.event_id);
            
            CreateTable(
                "dbo.SocialMediaSharings",
                c => new
                    {
                        share_id = c.Int(nullable: false, identity: true),
                        event_id = c.Int(nullable: false),
                        share_date = c.DateTime(nullable: false),
                        platform = c.String(),
                        share_description = c.String(),
                    })
                .PrimaryKey(t => t.share_id);
            
            AddColumn("dbo.Participants", "tournament_id", c => c.Int(nullable: false));
            AddColumn("dbo.Participants", "player_id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Participants", "player_id");
            DropColumn("dbo.Participants", "tournament_id");
            DropTable("dbo.SocialMediaSharings");
            DropTable("dbo.Events");
        }
    }
}
