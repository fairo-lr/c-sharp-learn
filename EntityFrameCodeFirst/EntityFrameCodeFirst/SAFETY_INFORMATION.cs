namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_INFORMATION
    {
        [Key]
        public int SI_ID { get; set; }

        public DateTime? SI_DATE { get; set; }

        [StringLength(5)]
        public string SI_SHIFT { get; set; }

        [StringLength(10)]
        public string SI_SUPERVISOR { get; set; }

        [StringLength(10)]
        public string SI_WEATHER { get; set; }

        [StringLength(512)]
        public string SI_HANDOVER { get; set; }

        public DateTime? SI_RECORDTM { get; set; }

        [StringLength(1)]
        public string SI_ISSUBMIT { get; set; }

        [StringLength(512)]
        public string SI_ATTENTION { get; set; }
    }
}
