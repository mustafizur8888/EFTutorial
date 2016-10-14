namespace EFTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class standardIdadded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Standard_StandardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "Standard_StandardId" });
            RenameColumn(table: "dbo.Students", name: "Standard_StandardId", newName: "StandardId");
            AlterColumn("dbo.Students", "StandardId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "StandardId");
            AddForeignKey("dbo.Students", "StandardId", "dbo.Standards", "StandardId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "StandardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "StandardId" });
            AlterColumn("dbo.Students", "StandardId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "StandardId", newName: "Standard_StandardId");
            CreateIndex("dbo.Students", "Standard_StandardId");
            AddForeignKey("dbo.Students", "Standard_StandardId", "dbo.Standards", "StandardId");
        }
    }
}
