namespace gtscoliar.mabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class option
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public option()
        {
            promoes = new HashSet<promo>();
            sections = new HashSet<section>();
        }

        [Key]
        [StringLength(10)]
        public string codeopstion { get; set; }

        [StringLength(50)]
        public string options { get; set; }

        public int? codesp { get; set; }

        [StringLength(50)]
        public string specialite { get; set; }

        public virtual Specialité Specialité { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<promo> promoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<section> sections { get; set; }
    }
}
