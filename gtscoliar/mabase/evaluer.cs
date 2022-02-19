namespace gtscoliar.mabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("evaluer")]
    public partial class evaluer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int anne_scoliar { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int module { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string stagiair { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string semastre { get; set; }

        public float? controle1 { get; set; }

        public float? controle2 { get; set; }

        public float? exm { get; set; }

        public float? ratrapag { get; set; }

        public virtual anne_scoliar anne_scoliar1 { get; set; }

        public virtual module module1 { get; set; }

        public virtual semasetre semasetre { get; set; }

        public virtual stg stg { get; set; }
    }
}
