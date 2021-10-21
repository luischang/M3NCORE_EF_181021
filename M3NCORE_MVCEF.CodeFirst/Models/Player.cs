using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M3NCORE_MVCEF.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name ="Futbolista: ")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "N° camiseta: ")]
        public int Dorsal { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "Age: ")]
        public int Age { get; set; }           

    }
}
