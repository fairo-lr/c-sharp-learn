namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_WORKS
    {
        [Key]
        public int SW_ID { get; set; }

        public DateTime SW_DATE { get; set; }

        [Required]
        [StringLength(5)]
        public string SW_SHIFT { get; set; }

        [StringLength(5)]
        public string SW_WKNO { get; set; }

        public int? SW_MV { get; set; }

        public int? SW_RV { get; set; }

        public int? SW_P_RV { get; set; }

        public int? SW_CK { get; set; }

        public int? SW_IN { get; set; }

        public int? SW_OUT { get; set; }

        public int? SW_DT { get; set; }

        public int? SW_XZ { get; set; }

        public int? SW_P_XZ { get; set; }

        public int? SW_ZZ { get; set; }

        [StringLength(1)]
        public string SW_FINALSTATE { get; set; }

        public int? SW_OUT_TIME_TRK { get; set; }

        public double? SW_IN_OUT { get; set; }

        public int? SW_CK_TIMEOUT { get; set; }

        public DateTime? SW_FINALTIME { get; set; }

        public int? SW_LASTSHIFT_TIMEOUT { get; set; }

        public int? SW_LASTSHIFT_CKTIMEOUT { get; set; }

        public int? SW_YMACHINE_TTL { get; set; }

        public int? SW_FLOWEMPTY_TTL { get; set; }

        public int? SW_ALLEMPTY_TTL { get; set; }

        public int? SW_OUT_TIMEOUT_30 { get; set; }

        public double? SW_CHECK_TTM { get; set; }

        public int? SW_IT_IN { get; set; }

        public int? SW_IT_OUT { get; set; }

        public int? SW_IT_TIMEOUT { get; set; }

        public int? SW_IT_LAST_TIMEOUT { get; set; }

        public int? SW_IT_MV { get; set; }

        public int? SW_IT_IN_OUT { get; set; }

        public double? SW_AVGTM_LES300 { get; set; }

        public double? SW_IT_AVGTM_LES300 { get; set; }

        public int? SW_GATE_OUT_F { get; set; }

        public int? SW_GATE_OUT_E { get; set; }

        public int? SW_CHK_OUT { get; set; }

        public int? SW_CHK_IN { get; set; }

        public int? SW_OUT_TIMEOUT_30_IT { get; set; }

        public int? SW_TIMEOUT_OUT_60 { get; set; }

        public int? SW_TIMEOUT_OUT_30 { get; set; }

        public int? SW_LASTSHIFT_TIMEOUT_OUT { get; set; }

        public double? SW_AVG_DEVTIME { get; set; }

        public int? SW_TIMEOUT_120 { get; set; }

        public int? SW_BUFF_COUNT { get; set; }

        public int? SW_EMPTY_YARD_COUNT { get; set; }
    }
}
