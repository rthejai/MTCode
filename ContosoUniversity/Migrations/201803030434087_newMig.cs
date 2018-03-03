namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Person", "CreditsEarned", c => c.Double());
            AddColumn("dbo.Person", "Gpa", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Gpa");
            DropColumn("dbo.Person", "CreditsEarned");
            DropColumn("dbo.Person", "Address");
        }
    }
}
