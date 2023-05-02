namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerGameAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerGames",
                c => new
                    {
                        Player_Game_Id = c.Int(nullable: false, identity: true),
                        Game_Name = c.String(nullable: false),
                        Player_Skill = c.String(),
                    })
                .PrimaryKey(t => t.Player_Game_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlayerGames");
        }
    }
}
