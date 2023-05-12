namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class playergameAndToken : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        token_id = c.Int(nullable: false, identity: true),
                        Token_key = c.String(nullable: false),
                        Created_at = c.DateTime(nullable: false),
                        deleted_at = c.DateTime(),
                        User_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.token_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tokens");
        }
    }
}
