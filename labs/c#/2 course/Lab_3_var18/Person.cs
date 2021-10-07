namespace Lab_3_var18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

        public int YearBirth { get; set; }

        [StringLength(50)]
        public string Schooling { get; set; }

        public DateTime DateAppcent { get; set; }
    }
}
