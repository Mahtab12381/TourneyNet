namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ranking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rankings",
                c => new
                    {
                        ranking_id = c.Int(nullable: false, identity: true),
                        rank = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ranking_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rankings");
        }
    }
}
