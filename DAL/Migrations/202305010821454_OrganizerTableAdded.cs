namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizerTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Organizers",
                c => new
                    {
                        Organizer_Id = c.Int(nullable: false, identity: true),
                        Organizer_Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Organizer_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Organizers");
        }
    }
}
