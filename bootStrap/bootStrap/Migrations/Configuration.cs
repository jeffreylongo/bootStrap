namespace bootStrap.Migrations
{
    using bootStrap.DataContext;
    using bootStrap.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<bootStrap.DataContext.SportContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(bootStrap.DataContext.SportContext db)
        {

            var sports = new List<Sports>
            {
                new Sports{Name = "Baseball"},
                new Sports{Name = "Basketball"},
                new Sports{Name = "Darts"},
                new Sports{Name = "Football"},
                new Sports{Name = "Golf"},
                new Sports{Name = "PingPong"},
                new Sports{Name = "Quidditch"}
            };
            sports.ForEach(sport => db.Sports.AddOrUpdate(s => s.Name, sport));
            db.SaveChanges();

            var teams = new List<Teams>
            {
                new Teams{ Image="/Images/dartboard.png", SportId =3,Name="Tampa Dart Dynamos", NumberOfPlayers = 8 },
                new Teams { Image="/Images/pingpong.jpg", SportId = 6, Name = "St Pete Ping Pong Powerhouse", NumberOfPlayers = 8},
                new Teams { Image="/Images/golf.jpg", SportId = 5, Name ="Orlando Golf Gang", NumberOfPlayers= 8},
                new Teams { Image="/Images/dartboard.png", SportId = 5, Name ="Buffalo BullsEyes", NumberOfPlayers= 8},
                new Teams { Image="/Images/pingpong.jpg", SportId = 5, Name ="Philly Paddlers", NumberOfPlayers= 8},
                new Teams { Image="/Images/golf.jpg", SportId = 5, Name ="Portland Putters", NumberOfPlayers= 8},
            };
            teams.ForEach(team => db.Teams.AddOrUpdate(t => t.Name, team));
            db.SaveChanges();

            var games = new List<Games>
            {
                new Games{ SportId =3, HomeTeamId=4, VisitingTeamId = 10, Score="20-17" },
                new Games{ SportId =6, HomeTeamId=5, VisitingTeamId = 11, Score="20-17" },
                new Games{ SportId =5, HomeTeamId=6, VisitingTeamId = 12, Score="20-17" }
                };

            games.ForEach(game => db.Games.AddOrUpdate(g => g.Sport, game));
            db.SaveChanges();
        }
    }
}
