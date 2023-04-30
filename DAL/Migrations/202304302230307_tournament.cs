namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tournament : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        tournament_id = c.Int(nullable: false, identity: true),
                        tournament_name = c.String(),
                        tournament_description = c.String(),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        registration_deadline = c.DateTime(nullable: false),
                        tournament_rules = c.String(),
                    })
                .PrimaryKey(t => t.tournament_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tournaments");
        }
    }
}
