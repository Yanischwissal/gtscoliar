namespace gtscoliar.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("module")]
    public partial class module
    {
        [Key]
        public int codemodul { get; set; }

        [Column("module")]
        [StringLength(50)]
        public string module1 { get; set; }
    }
}
