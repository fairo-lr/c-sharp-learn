namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_MACHINE_WORK
    {
        [Key]
        public int MW_ID { get; set; }

        public DateTime MW_DATE { get; set; }

        [Required]
        [StringLength(5)]
        public string MW_SHIFT { get; set; }

        [StringLength(5)]
        public string MW_WKNO { get; set; }

        public int? MW_CRANE { get; set; }

        public int? MW_RTG { get; set; }

        public int? MW_ECORTG { get; set; }

        public int? MW_RSC { get; set; }

        public int? MW_EHC { get; set; }

        public int? MW_TRK { get; set; }

        public double? MW_CAB { get; set; }

        public double? MW_YARD { get; set; }

        public double? MW_TRUCK { get; set; }

        [StringLength(1)]
        public string MW_FINALSTATE { get; set; }

        public DateTime? MW_FINALTIME { get; set; }

        [StringLength(50)]
        public string MW_MACHINE_TIME { get; set; }

        public double? MW_ECORTG_TIME { get; set; }

        public double? MW_ALLRTG_TIME { get; set; }

        public int? MW_BRI_TTL { get; set; }

        public double? MW_BRI_TIME { get; set; }

        public int? MW_RTG_TTL { get; set; }

        public double? MW_RTG_TIME { get; set; }

        public int? MW_FLOW_TTL { get; set; }

        public double? MW_FLOW_TIME { get; set; }

        public double? MW_ECO_BREAK_TTM { get; set; }

        public int? MW_PURE_RTG { get; set; }
    }
}
