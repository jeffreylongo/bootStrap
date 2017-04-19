namespace bootStrap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportId = c.Int(),
                        HomeTeamId = c.Int(),
                        VisitingTeamId = c.Int(),
                        Score = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.HomeTeamId)
                .ForeignKey("dbo.Sports", t => t.SportId)
                .ForeignKey("dbo.Teams", t => t.VisitingTeamId)
                .Index(t => t.SportId)
                .Index(t => t.HomeTeamId)
                .Index(t => t.VisitingTeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportId = c.Int(nullable: false),
                        Name = c.String(),
                        NumberOfPlayers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sports", t => t.SportId)
                .Index(t => t.SportId);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "VisitingTeamId", "dbo.Teams");
            DropForeignKey("dbo.Games", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Games", "HomeTeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "SportId", "dbo.Sports");
            DropIndex("dbo.Teams", new[] { "SportId" });
            DropIndex("dbo.Games", new[] { "VisitingTeamId" });
            DropIndex("dbo.Games", new[] { "HomeTeamId" });
            DropIndex("dbo.Games", new[] { "SportId" });
            DropTable("dbo.Sports");
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
        }
    }
}
