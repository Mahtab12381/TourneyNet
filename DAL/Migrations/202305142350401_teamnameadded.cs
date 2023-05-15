namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teamnameadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rankings", "team_name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rankings", "team_name");
        }
    }
}
