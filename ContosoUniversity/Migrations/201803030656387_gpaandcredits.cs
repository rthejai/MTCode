namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gpaandcredits : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "CreditsEarned", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "CreditsEarned");
        }
    }
}
