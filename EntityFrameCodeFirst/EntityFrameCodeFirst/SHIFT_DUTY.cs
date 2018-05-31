namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_DUTY
    {
        [Key]
        public int SD_ID { get; set; }

        public DateTime SD_DATE { get; set; }

        [Required]
        [StringLength(5)]
        public string SD_SHIFT { get; set; }

        [StringLength(5)]
        public string SD_WKNO { get; set; }

        public int? SD_MANAGER { get; set; }

        public int? SD_SUPERVISOR { get; set; }

        public int? SD_CONTROL { get; set; }

        public int? SD_STOWPLAN { get; set; }

        public int? SD_COODINATOR { get; set; }

        public int? SD_CAB_MOR { get; set; }

        public int? SD_CRANE { get; set; }

        public int? SD_RTG { get; set; }

        public int? SD_RSEH { get; set; }

        public int? SD_LABOR { get; set; }

        public int? SD_IN_TRK { get; set; }

        public int? SD_FOREMAN { get; set; }

        public int? SD_GATE { get; set; }

        public int? SD_VELWORKTTL { get; set; }

        public double? SD_WORKTIMETTL { get; set; }

        public double? SD_AVGWORKTIME { get; set; }

        public int? SD_VESSELTTL { get; set; }

        [StringLength(1)]
        public string SD_FINALSTATE { get; set; }

        public DateTime? SD_FINALTIME { get; set; }

        public int? SD_IT_CRANE { get; set; }

        public int? SD_IT_RTG { get; set; }

        public int? SD_IT_RSEH { get; set; }

        public int? SD_IT_GATE { get; set; }

        public int? SD_IT_IN_TRK { get; set; }

        public int? SD_IT_LABOR { get; set; }

        public int? SD_IT_FOREMAN { get; set; }
    }
}
