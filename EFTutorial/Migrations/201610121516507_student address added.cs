namespace EFTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentaddressadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Zipcode = c.Int(nullable: false),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "StudentId" });
            DropTable("dbo.StudentAddresses");
        }
    }
}
