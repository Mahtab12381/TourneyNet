namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FanPost_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FanPosts",
                c => new
                    {
                        FanPost_id = c.Int(nullable: false, identity: true),
                        PostContent = c.String(),
                        PostDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FanPost_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FanPosts");
        }
    }
}
