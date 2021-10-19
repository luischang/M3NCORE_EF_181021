using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3NCORE_EF.CodeFirst.Models
{
    public class CopaLibertadoresDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=CopaLibertadoresDB;User=MyUser;Pwd=MyPassword";
            string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=CopaLibertadoresDB;Trusted_Connection=true;MultipleActiveResultSets=true";

            builder
                .UseSqlServer(cnx)
                .LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(builder);
        }

        public virtual DbSet<Player> Player { get; set; } 
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<SoccerPosition> SoccerPosition { get; set; }


    }
}
