using System;
using System.Collections.Generic;

#nullable disable

namespace M3NCORE_MVCEF.DatabaseFirst.Models
{
    public partial class Team
    {
        public Team()
        {
            PlayerTeam = new HashSet<PlayerTeam>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public int? Trophies { get; set; }

        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; }
    }
}
