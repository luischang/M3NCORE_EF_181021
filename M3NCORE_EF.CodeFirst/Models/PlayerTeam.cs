using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3NCORE_EF.CodeFirst.Models
{
    public class PlayerTeam
    {

        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        
        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }

    }
}
