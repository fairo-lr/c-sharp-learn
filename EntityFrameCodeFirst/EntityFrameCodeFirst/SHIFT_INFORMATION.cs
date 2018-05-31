namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_INFORMATION
    {
        [Key]
        public int SI_ID { get; set; }

        public DateTime SI_DATE { get; set; }

        [Required]
        [StringLength(5)]
        public string SI_SHIFT { get; set; }

        [StringLength(5)]
        public string SI_WKNO { get; set; }

        [StringLength(10)]
        public string SI_MANAGER { get; set; }

        [StringLength(10)]
        public string SI_SUPERVISOR { get; set; }

        [StringLength(10)]
        public string SI_WEATHER { get; set; }

        [StringLength(512)]
        public string SI_SAFT_ACC { get; set; }

        [StringLength(512)]
        public string SI_NOT_ACC { get; set; }

        [StringLength(512)]
        public string SI_HANDOVER { get; set; }

        [StringLength(1)]
        public string SI_FINALSTATE { get; set; }

        public DateTime? SI_FINALTIME { get; set; }

        [StringLength(1)]
        public string SI_SYS_SUBMIT { get; set; }

        [StringLength(1)]
        public string SI_SYS_VSS_SUB { get; set; }

        [StringLength(512)]
        public string SI_OPSCAB { get; set; }
    }
}
