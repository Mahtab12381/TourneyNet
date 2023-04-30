namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class payment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        payment_id = c.Int(nullable: false, identity: true),
                        amount_paid = c.Single(nullable: false),
                        payment_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.payment_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Payments");
        }
    }
}
