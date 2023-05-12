namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fanRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fans", "Fan_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Fans", "Fan_Id");
            AddForeignKey("dbo.Fans", "Fan_Id", "dbo.Registrations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fans", "Fan_Id", "dbo.Registrations");
            DropIndex("dbo.Fans", new[] { "Fan_Id" });
            DropColumn("dbo.Fans", "Fan_Id");
        }
    }
}
