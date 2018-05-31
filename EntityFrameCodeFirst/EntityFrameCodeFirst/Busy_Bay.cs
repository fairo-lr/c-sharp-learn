namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_Bay
    {
        [Key]
        public int Bb_id { get; set; }

        public DateTime? Bb_Date { get; set; }

        [StringLength(10)]
        public string Bb_PlanType { get; set; }

        [StringLength(50)]
        public string Bb_Plan { get; set; }

        [StringLength(10)]
        public string Bb_cntrSize { get; set; }

        [StringLength(10)]
        public string Bb_cntrHeight { get; set; }

        [StringLength(10)]
        public string Bb_cntrType { get; set; }

        [StringLength(100)]
        public string Bb_cstmnm { get; set; }

        public DateTime? Bb_planStartTime { get; set; }

        public DateTime? Bb_PlanEndTime { get; set; }

        [StringLength(20)]
        public string Bb_PlanNo { get; set; }

        [StringLength(20)]
        public string Bb_PlanTo { get; set; }

        public int? Bb_PlanNum { get; set; }

        [StringLength(10)]
        public string Bb_startBay { get; set; }

        [StringLength(10)]
        public string Bb_endBay { get; set; }

        public DateTime? bb_recordtime { get; set; }

        public int? bb_planid { get; set; }
    }
}
