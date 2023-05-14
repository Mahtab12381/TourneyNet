namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rankingupdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rankings", "Match_palyed", c => c.Int(nullable: false));
            AddColumn("dbo.Rankings", "Match_lost", c => c.Int(nullable: false));
            AddColumn("dbo.Rankings", "Match_won", c => c.Int(nullable: false));
            AddColumn("dbo.Rankings", "Total_point", c => c.Int(nullable: false));
            DropColumn("dbo.Rankings", "rank");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rankings", "rank", c => c.Int(nullable: false));
            DropColumn("dbo.Rankings", "Total_point");
            DropColumn("dbo.Rankings", "Match_won");
            DropColumn("dbo.Rankings", "Match_lost");
            DropColumn("dbo.Rankings", "Match_palyed");
        }
    }
}
