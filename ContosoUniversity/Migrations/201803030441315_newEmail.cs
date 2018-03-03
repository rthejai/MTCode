namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newEmail : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "Address", c => c.String(maxLength: 50));
        }
    }
}
