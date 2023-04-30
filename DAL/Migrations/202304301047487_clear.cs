namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clear : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Bio = c.String(nullable: false),
                        ContactInformation = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        participant_id = c.Int(nullable: false, identity: true),
                        team_name = c.String(),
                        team_logo = c.String(),
                    })
                .PrimaryKey(t => t.participant_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Participants");
            DropTable("dbo.Fans");
        }
    }
}
