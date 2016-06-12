namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPartnerValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Partner", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Partner", "Name", c => c.String());
        }
    }
}
