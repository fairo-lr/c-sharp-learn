namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SITUATION
    {
        [Key]
        public int SS_ID { get; set; }

        public DateTime? SS_DATE { get; set; }

        [StringLength(5)]
        public string SS_SHIFT { get; set; }

        [StringLength(512)]
        public string SS_VESSEL { get; set; }

        [StringLength(512)]
        public string SS_YARD { get; set; }

        [StringLength(512)]
        public string SS_MACHINE { get; set; }

        [StringLength(512)]
        public string SS_SPECIAL { get; set; }

        [StringLength(512)]
        public string SS_TRAFFIC { get; set; }

        [StringLength(512)]
        public string SS_GATE { get; set; }

        [StringLength(512)]
        public string SS_HEALTH { get; set; }

        [StringLength(512)]
        public string SS_ISPS { get; set; }

        public DateTime? SS_RECORDTM { get; set; }
    }
}
