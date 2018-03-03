namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Gpa", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.Person", "CreditsEarned");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "CreditsEarned", c => c.Int());
            DropColumn("dbo.Person", "Gpa");
        }
    }
}
