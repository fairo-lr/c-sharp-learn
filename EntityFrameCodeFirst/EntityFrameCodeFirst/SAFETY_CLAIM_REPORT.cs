namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_CLAIM_REPORT
    {
        [Key]
        public int SCR_ID { get; set; }

        public int? SCR_SB_ID { get; set; }

        [StringLength(50)]
        public string SCR_TITLE { get; set; }

        public DateTime? SCR_ACC_T { get; set; }

        public DateTime? SCR_CLAIM_ST { get; set; }

        public DateTime? SCR_CLAIM_ET { get; set; }

        [StringLength(20)]
        public string SCR_COMPANY { get; set; }

        [StringLength(50)]
        public string SCR_SUBJECT { get; set; }

        [StringLength(20)]
        public string SCR_AMOUNT { get; set; }

        [StringLength(50)]
        public string SCR_NAME { get; set; }

        public string SCR_ACC_CONTENT { get; set; }

        [StringLength(50)]
        public string SCR_OTHERS { get; set; }

        [StringLength(50)]
        public string SCR_NOTES { get; set; }

        public DateTime? SCR_CREATDATE { get; set; }

        public virtual SAFETY_BREAKRULE SAFETY_BREAKRULE { get; set; }
    }
}
