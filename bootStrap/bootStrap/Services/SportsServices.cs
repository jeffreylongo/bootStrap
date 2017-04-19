using bootStrap.DataContext;
using bootStrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bootStrap.Services
{
    public class SportsServices
    {
        public List<Sports> GetSports()
        {
            var db = new SportContext();
            var sports = db.Sports.ToList();
            return sports;
        }

        public List<Teams> GetTeams()
        {
            var db = new SportContext();
            var teams = db.Teams.ToList();
            return teams;
        }

        public List<Games> GetGames()
        {
            var db = new SportContext();
            var games = db.Games.ToList();
            return games;
        }
    }
}