namespace gtscoliar.mabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stg")]
    public partial class stg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stg()
        {
            evaluers = new HashSet<evaluer>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluer> evaluers { get; set; }

        public virtual promo promo { get; set; }

        public virtual section section { get; set; }
    }
}
