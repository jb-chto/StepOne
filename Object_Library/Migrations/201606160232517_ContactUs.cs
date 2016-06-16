namespace Object_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactUs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactUs",
                c => new
                    {
                        ContactUsId = c.Int(nullable: false, identity: true),
                        date_of_send = c.DateTime(nullable: false),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        subject = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        readed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ContactUsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactUs");
        }
    }
}
