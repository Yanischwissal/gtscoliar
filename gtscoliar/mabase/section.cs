namespace gtscoliar.mabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("section")]
    public partial class section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public section()
        {
            stgs = new HashSet<stg>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numrosction { get; set; }

        [StringLength(50)]
        public string nomsection { get; set; }

        [StringLength(10)]
        public string modeformation { get; set; }

        [StringLength(10)]
        public string options { get; set; }

        public int? promo { get; set; }

        public virtual option option { get; set; }

        public virtual promo promo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stg> stgs { get; set; }
    }
}
