namespace gtscoliar.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specialité
    {
        [Key]
        [StringLength(50)]
        public string codesp { get; set; }

        [StringLength(50)]
        public string Specialite { get; set; }

        public int? branche { get; set; }
    }
}
