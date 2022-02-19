namespace gtscoliar.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("section")]
    public partial class section
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numrosction { get; set; }

        [StringLength(50)]
        public string nomsection { get; set; }

        [StringLength(10)]
        public string modeformation { get; set; }

        [StringLength(10)]
        public string options { get; set; }

        public int promo { get; set; }
    }
}
