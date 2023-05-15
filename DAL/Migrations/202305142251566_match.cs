namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class match : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matches", "Match_start_time", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Matches", "Match_end_time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matches", "Match_end_time", c => c.DateTime());
            AlterColumn("dbo.Matches", "Match_start_time", c => c.DateTime());
        }
    }
}
