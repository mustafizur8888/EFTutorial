namespace EFTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeforeginkeyoptional : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "StandardId", "dbo.Standards");
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "StandardId" });
            DropIndex("dbo.Students", new[] { "TeacherId" });
            AddColumn("dbo.Standards", "StandardName", c => c.String());
            AlterColumn("dbo.Students", "StandardId", c => c.Int());
            AlterColumn("dbo.Students", "TeacherId", c => c.Int());
            CreateIndex("dbo.Students", "StandardId");
            CreateIndex("dbo.Students", "TeacherId");
            AddForeignKey("dbo.Students", "StandardId", "dbo.Standards", "StandardId");
            AddForeignKey("dbo.Students", "TeacherId", "dbo.Teachers", "TeacherId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Students", "StandardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "TeacherId" });
            DropIndex("dbo.Students", new[] { "StandardId" });
            AlterColumn("dbo.Students", "TeacherId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "StandardId", c => c.Int(nullable: false));
            DropColumn("dbo.Standards", "StandardName");
            CreateIndex("dbo.Students", "TeacherId");
            CreateIndex("dbo.Students", "StandardId");
            AddForeignKey("dbo.Students", "TeacherId", "dbo.Teachers", "TeacherId", cascadeDelete: true);
            AddForeignKey("dbo.Students", "StandardId", "dbo.Standards", "StandardId", cascadeDelete: true);
        }
    }
}
