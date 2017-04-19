using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bootStrap.Models
{
    public class Teams
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public string Name { get; set; }
        public int NumberOfPlayers { get; set; }

        public virtual Sports Sport { get; set; }
    }
}