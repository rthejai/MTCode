namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pending : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Person", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Person", "LastName", c => c.String(maxLength: 50));
        }
    }
}
