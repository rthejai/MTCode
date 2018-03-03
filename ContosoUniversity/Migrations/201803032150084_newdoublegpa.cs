namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdoublegpa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "Gpa", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "Gpa", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
