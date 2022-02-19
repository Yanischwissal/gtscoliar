namespace gtscoliar.mabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specialité
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specialité()
        {
            options = new HashSet<option>();
        }

        [Key]
        [StringLength(50)]
        public string codesp { get; set; }

        [StringLength(50)]
        public string Specialite { get; set; }

        public int? branche { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<option> options { get; set; }
    }
}
