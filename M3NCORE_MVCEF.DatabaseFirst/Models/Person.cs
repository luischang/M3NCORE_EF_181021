using System;
using System.Collections.Generic;

#nullable disable

namespace M3NCORE_MVCEF.DatabaseFirst.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? Active { get; set; }
    }
}
