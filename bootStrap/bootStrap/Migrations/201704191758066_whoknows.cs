namespace bootStrap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class whoknows : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportId = c.Int(nullable: false),
                        Name = c.String(),
                        NumberOfPlayers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Teams_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Teams_Id)
                .Index(t => t.Teams_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sports", "Teams_Id", "dbo.Teams");
            DropIndex("dbo.Sports", new[] { "Teams_Id" });
            DropTable("dbo.Sports");
            DropTable("dbo.Teams");
        }
    }
}
