namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_STACK_PLANS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS_STACK_PLANS()
        {
            PS_STACK_PLAN_AREAS = new HashSet<PS_STACK_PLAN_AREAS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal SPL_YPLANID { get; set; }

        [Required]
        [StringLength(10)]
        public string SPL_TYPE { get; set; }

        public DateTime SPL_PTIME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPL_CAMT { get; set; }

        [Required]
        [StringLength(5)]
        public string SPL_EMPTID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPL_EFFPERIOD { get; set; }

        [StringLength(1)]
        public string SPL_SELECTMD { get; set; }

        [StringLength(1)]
        public string SPL_DMGCFG { get; set; }

        [StringLength(1)]
        public string SPL_RFCFG { get; set; }

        [StringLength(1)]
        public string SPL_CSZ_CSIZECD { get; set; }

        [StringLength(1)]
        public string SPL_DNGGFG { get; set; }

        [StringLength(11)]
        public string SPL_CNTRNO { get; set; }

        [StringLength(2)]
        public string SPL_CTP_ISOCD { get; set; }

        [StringLength(1)]
        public string SPL_OVLMTFG { get; set; }

        [StringLength(1)]
        public string SPL_HEI_CHEIGHTCD { get; set; }

        [StringLength(4)]
        public string SPL_COP_COPERCD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPL_VOC_OCRRID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPL_STS_CSTATUSID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPL_ULP_PORTID { get; set; }

        [Required]
        [StringLength(1)]
        public string SPL_TER_TERMCD { get; set; }

        [StringLength(6)]
        public string SPL_REGIONCD { get; set; }

        public DateTime? SPL_OPSTTM { get; set; }

        public DateTime? SPL_OPEDTM { get; set; }

        public double? SPL_DVP_PLANNO { get; set; }

        [StringLength(3)]
        public string SPL_POT_PORTCD { get; set; }

        [StringLength(1)]
        public string SPL_CGROUPFG { get; set; }

        [StringLength(25)]
        public string SPL_BILLNO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPL_OUTSEQ { get; set; }

        [StringLength(1)]
        public string SPL_EMPTY { get; set; }

        [StringLength(1)]
        public string SPL_SPSTOWFG { get; set; }

        public DateTime? SPL_LOGTIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_STACK_PLAN_AREAS> PS_STACK_PLAN_AREAS { get; set; }
    }
}
