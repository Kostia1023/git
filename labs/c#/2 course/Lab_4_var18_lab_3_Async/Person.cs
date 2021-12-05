namespace Lab_4_var18_lab_3_Async
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persons")]
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
