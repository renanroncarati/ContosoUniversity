namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartnerRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "PartnerID", c => c.Int());
            CreateIndex("dbo.Course", "PartnerID");
            AddForeignKey("dbo.Course", "PartnerID", "dbo.Partner", "PartnerID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course", "PartnerID", "dbo.Partner");
            DropIndex("dbo.Course", new[] { "PartnerID" });
            DropColumn("dbo.Course", "PartnerID");
        }
    }
}
