namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2ndNewMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "Address", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "Address", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
