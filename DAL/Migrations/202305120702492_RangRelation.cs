namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RangRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rankings", "participant_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rankings", "participant_id");
            AddForeignKey("dbo.Rankings", "participant_id", "dbo.Participants", "participant_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rankings", "participant_id", "dbo.Participants");
            DropIndex("dbo.Rankings", new[] { "participant_id" });
            DropColumn("dbo.Rankings", "participant_id");
        }
    }
}
