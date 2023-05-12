namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tokenregidadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "reg_id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tokens", "reg_id");
        }
    }
}
