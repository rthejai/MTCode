namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reverted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Person", "CreditsEarned");
            DropColumn("dbo.Person", "Gpa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "Gpa", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Person", "CreditsEarned", c => c.Int());
        }
    }
}
