namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class playerAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        player_Id = c.Int(nullable: false, identity: true),
                        gender = c.String(),
                        nationality = c.String(),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.player_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
