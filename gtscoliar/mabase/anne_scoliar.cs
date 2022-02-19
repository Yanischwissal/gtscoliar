namespace gtscoliar.mabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class anne_scoliar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public anne_scoliar()
        {
            evaluers = new HashSet<evaluer>();
        }

        [Key]
        public int code_anne { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_dubel { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_fin { get; set; }

        [StringLength(50)]
        public string session_scoliar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluer> evaluers { get; set; }
    }
}
