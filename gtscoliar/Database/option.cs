namespace gtscoliar.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class option
    {
        [Key]
        [StringLength(10)]
        public string codeopstion { get; set; }

        [StringLength(50)]
        public string options { get; set; }

        public int? codesp { get; set; }

        [StringLength(50)]
        public string specialite { get; set; }
    }
}
