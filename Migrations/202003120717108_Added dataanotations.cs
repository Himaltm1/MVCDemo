namespace MVCDemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addeddataanotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String(maxLength: 20));
            DropColumn("dbo.Students", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Phone", c => c.Byte(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
        }
    }
}
