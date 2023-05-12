namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedRelations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "participant_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Payments", "participant_id");
            AddForeignKey("dbo.Payments", "participant_id", "dbo.Participants", "participant_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "participant_id", "dbo.Participants");
            DropIndex("dbo.Payments", new[] { "participant_id" });
            DropColumn("dbo.Payments", "participant_id");
        }
    }
}
