namespace gtscoliar.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stg")]
    public partial class stg
    {
        [Key]
        [StringLength(50)]
        public string numstg { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string prenom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_naissance { get; set; }

        [StringLength(10)]
        public string sexe { get; set; }

        [StringLength(50)]
        public string adersse { get; set; }

        [StringLength(50)]
        public string commune { get; set; }

        public int? code_postal { get; set; }

        [StringLength(10)]
        public string telephone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string niveau_scolaire { get; set; }

        [StringLength(50)]
        public string prenom_pere { get; set; }

        [StringLength(50)]
        public string nom_mere { get; set; }

        [StringLength(50)]
        public string prenom_mere { get; set; }

        [StringLength(50)]
        public string nasionalite { get; set; }

        public int? numpro { get; set; }

        public int? numrosection { get; set; }
    }
}
