namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ur : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Registration_Id", "dbo.Registrations");
            DropForeignKey("dbo.Rankings", "Tournament_tournament_id", "dbo.Tournaments");
            DropIndex("dbo.Players", new[] { "Registration_Id" });
            DropIndex("dbo.Rankings", new[] { "Tournament_tournament_id" });
            RenameColumn(table: "dbo.Players", name: "Registration_Id", newName: "player_reg_id");
            RenameColumn(table: "dbo.Rankings", name: "Tournament_tournament_id", newName: "tournament_id");
            AlterColumn("dbo.Players", "player_reg_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Rankings", "tournament_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Players", "player_reg_id");
            AddForeignKey("dbo.Players", "player_reg_id", "dbo.Registrations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "player_reg_id", "dbo.Registrations");
            DropIndex("dbo.Players", new[] { "player_reg_id" });
            AlterColumn("dbo.Rankings", "tournament_id", c => c.Int());
            AlterColumn("dbo.Players", "player_reg_id", c => c.Int());
            RenameColumn(table: "dbo.Rankings", name: "tournament_id", newName: "Tournament_tournament_id");
            RenameColumn(table: "dbo.Players", name: "player_reg_id", newName: "Registration_Id");
            CreateIndex("dbo.Rankings", "Tournament_tournament_id");
            CreateIndex("dbo.Players", "Registration_Id");
            AddForeignKey("dbo.Rankings", "Tournament_tournament_id", "dbo.Tournaments", "tournament_id");
            AddForeignKey("dbo.Players", "Registration_Id", "dbo.Registrations", "Id");
        }
    }
}
