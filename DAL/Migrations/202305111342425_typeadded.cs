namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typeadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tokens", "Type");
        }
    }
}
