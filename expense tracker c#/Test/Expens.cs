namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Expenses")]
    public partial class Expens
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Amount { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Memo { get; set; }

        [Required]
        public string Account { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
    }
}
