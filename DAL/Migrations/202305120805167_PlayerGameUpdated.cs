namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerGameUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerGames", "Player_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.PlayerGames", "Player_Id");
            AddForeignKey("dbo.PlayerGames", "Player_Id", "dbo.Players", "player_Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerGames", "Player_Id", "dbo.Players");
            DropIndex("dbo.PlayerGames", new[] { "Player_Id" });
            DropColumn("dbo.PlayerGames", "Player_Id");
        }
    }
}
