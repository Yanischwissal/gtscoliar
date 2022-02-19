namespace gtscoliar.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("promo")]
    public partial class promo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code_Promo { get; set; }

        [StringLength(50)]
        public string Diplome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_debut_de_formation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_fin_de_formation { get; set; }

        [StringLength(10)]
        public string opption { get; set; }

        [StringLength(10)]
        public string modeformation { get; set; }
    }
}
