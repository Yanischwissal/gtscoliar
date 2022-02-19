namespace gtscoliar.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mode de formation")]
    public partial class mode_de_formation
    {
        [Key]
        [StringLength(10)]
        public string codemodef { get; set; }

        [StringLength(50)]
        public string mode_formation { get; set; }
    }
}
