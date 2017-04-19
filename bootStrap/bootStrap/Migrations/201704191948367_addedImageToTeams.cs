namespace bootStrap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedImageToTeams : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Image");
        }
    }
}
