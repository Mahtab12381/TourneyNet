namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class matchesupdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matches", "Match_start_time", c => c.DateTime());
            AlterColumn("dbo.Matches", "Match_end_time", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matches", "Match_end_time", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Matches", "Match_start_time", c => c.DateTime(nullable: false));
        }
    }
}
