namespace DB_Assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactsId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adress = c.String(),
                        Zipcode = c.String(),
                        City = c.String(),
                        Phonenumber = c.String(),
                        Email = c.String(),
                        Birthday = c.String(),
                    })
                .PrimaryKey(t => t.ContactsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
