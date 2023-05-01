namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StreamTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Streams",
                c => new
                    {
                        Stream_id = c.Int(nullable: false, identity: true),
                        Event_id = c.Int(nullable: false),
                        Stream_link = c.String(nullable: false),
                        Stream_description = c.String(),
                    })
                .PrimaryKey(t => t.Stream_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Streams");
        }
    }
}
