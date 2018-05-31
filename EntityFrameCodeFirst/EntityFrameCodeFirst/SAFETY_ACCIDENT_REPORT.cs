namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_ACCIDENT_REPORT
    {
        [Key]
        public int SAR_ID { get; set; }

        public int? SAR_SB_ID { get; set; }

        public DateTime? SAR_CREATDATE { get; set; }

        [StringLength(50)]
        public string SAR_TITLE { get; set; }

        public string SAR_CONTENT { get; set; }

        public string SAR_CAUSE { get; set; }

        public string SAR_RESULT { get; set; }

        public string SAR_ADVICE { get; set; }

        [StringLength(1)]
        public string SAR_ISFINISH { get; set; }

        [StringLength(20)]
        public string SAR_WRITER { get; set; }

        public string SAR_PART2 { get; set; }

        public string SAR_PART3 { get; set; }

        public string SAR_PART4 { get; set; }

        public virtual SAFETY_BREAKRULE SAFETY_BREAKRULE { get; set; }
    }
}
