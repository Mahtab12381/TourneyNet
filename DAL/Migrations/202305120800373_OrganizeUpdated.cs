namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizeUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizers", "Organizer_by", c => c.Int(nullable: false));
            CreateIndex("dbo.Organizers", "Organizer_by");
            AddForeignKey("dbo.Organizers", "Organizer_by", "dbo.Registrations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Organizers", "Organizer_by", "dbo.Registrations");
            DropIndex("dbo.Organizers", new[] { "Organizer_by" });
            DropColumn("dbo.Organizers", "Organizer_by");
        }
    }
}
