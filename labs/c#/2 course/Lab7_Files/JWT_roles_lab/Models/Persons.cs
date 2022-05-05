using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JWT_roles_lab.Models
{
    public partial class Persons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int YearBirth { get; set; }
        public string Schooling { get; set; }
        public DateTime DateAppcent { get; set; }
    }
}
