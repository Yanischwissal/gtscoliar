namespace gtscoliar.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("semasetre")]
    public partial class semasetre
    {
        [Key]
        [StringLength(10)]
        public string somestre { get; set; }
    }
}
