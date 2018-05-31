namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_Information
    {
        [Key]
        public int BI_ID { get; set; }
        public DateTime? BI_Date { get; set; }

        [StringLength(20)]
        public string BI_day { get; set; }

        [StringLength(20)]
        public string BI_SHIFT { get; set; }

        [StringLength(10)]
        public string BI_SUPERVISOR { get; set; }

        [StringLength(10)]
        public string BI_YardPeople { get; set; }

        [StringLength(512)]
        public string BI_HANDOVER { get; set; }

        public DateTime? BI_RECORDTM { get; set; }

        [StringLength(1)]
        public string BI_ISSUBMIT { get; set; }

        [StringLength(500)]
        public string BI_MACHINE { get; set; }

        [StringLength(500)]
        public string BI_YARD { get; set; }

        [StringLength(1)]
        public string BI_ISREADED { get; set; }

        [StringLength(1)]
        public string BI_ISMONREADED { get; set; }
    }
}
