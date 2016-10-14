namespace EFTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makestudentheight : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Height", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Students", "Weight", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Weight", c => c.Single(nullable: false));
            AlterColumn("dbo.Students", "Height", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
