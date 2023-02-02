namespace Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename_groups : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ApplicationGroups", newName: "Groups");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Groups", newName: "ApplicationGroups");
        }
    }
}
