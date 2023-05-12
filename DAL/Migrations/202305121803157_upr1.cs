namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upr1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Matches", "Team_Team_id", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "Team_Team_id" });
            DropColumn("dbo.Matches", "Team_Team_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "Team_Team_id", c => c.Int());
            CreateIndex("dbo.Matches", "Team_Team_id");
            AddForeignKey("dbo.Matches", "Team_Team_id", "dbo.Teams", "Team_id");
        }
    }
}
