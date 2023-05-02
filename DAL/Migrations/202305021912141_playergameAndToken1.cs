namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class playergameAndToken1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tokens", "User_id", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tokens", "User_id", c => c.Int(nullable: false));
        }
    }
}
