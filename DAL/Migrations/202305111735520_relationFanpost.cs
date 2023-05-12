namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationFanpost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FanPosts", "Posted_by_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.FanPosts", "Posted_by_Id");
            AddForeignKey("dbo.FanPosts", "Posted_by_Id", "dbo.Registrations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FanPosts", "Posted_by_Id", "dbo.Registrations");
            DropIndex("dbo.FanPosts", new[] { "Posted_by_Id" });
            DropColumn("dbo.FanPosts", "Posted_by_Id");
        }
    }
}
