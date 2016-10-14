namespace EFTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacherId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Teacher_TeacherId", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "Teacher_TeacherId" });
            RenameColumn(table: "dbo.Students", name: "Teacher_TeacherId", newName: "TeacherId");
            AlterColumn("dbo.Students", "TeacherId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "TeacherId");
            AddForeignKey("dbo.Students", "TeacherId", "dbo.Teachers", "TeacherId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "TeacherId" });
            AlterColumn("dbo.Students", "TeacherId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "TeacherId", newName: "Teacher_TeacherId");
            CreateIndex("dbo.Students", "Teacher_TeacherId");
            AddForeignKey("dbo.Students", "Teacher_TeacherId", "dbo.Teachers", "TeacherId");
        }
    }
}
