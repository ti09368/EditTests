namespace Edit1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Record")]
    public partial class Record
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        public string Description { get; set; }

        //[Column(Order = 2)]
        //public string Tag { get; set; }

        [Column(Order = 3)]
        public float Value { get; set; }
    }
}
