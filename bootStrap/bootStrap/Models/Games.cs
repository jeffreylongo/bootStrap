using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bootStrap.Models
{
    public class Games
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public int HomeTeamId { get; set; }
        public int VisitingTeamId { get; set; }
        public string Score { get; set; }

        public virtual ICollection<Sports> Sports { get; set; } = new HashSet<Sports>();
        public virtual ICollection<Teams> Teams { get; set; } = new HashSet<Teams>();

    }
}