using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M3NCORE_MVCEF.CodeFirst.Models
{
    public class CopaSudamericanaDBContext : DbContext
    {
        public CopaSudamericanaDBContext(DbContextOptions<CopaSudamericanaDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Player> Player { get; set; }

    }
}
