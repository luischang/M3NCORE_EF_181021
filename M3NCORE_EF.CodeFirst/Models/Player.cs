using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3NCORE_EF.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName="nvarchar(100)")]
        public string FullName { get; set; }
        [Column(TypeName ="int")]
        public int Dorsal { get; set; }
        [Column(TypeName = "int")]
        public int Age { get; set; }
        [Column(TypeName = "int")]
        public int SoccerPositionId { get; set; }
        public virtual SoccerPosition SoccerPosition { get; set; }

        public virtual List<Team> Team { get; set; }

    }
}
