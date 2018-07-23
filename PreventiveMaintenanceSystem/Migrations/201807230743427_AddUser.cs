namespace PreventiveMaintenanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        Address = c.String(),
                        EmailAddress = c.String(),
                        ContactNo = c.String(),
                        AccountType = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        SecurityQuestion1 = c.String(),
                        SecurityQuestion2 = c.String(),
                        SecurityQuestion1Answer = c.String(),
                        SecurityQuestion2Answer = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
