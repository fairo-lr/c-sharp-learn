namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_COMPENSATION_REPORT
    {
        [Key]
        public int SCPR_ID { get; set; }

        public int? SCPR_SB_ID { get; set; }

        [StringLength(50)]
        public string SCPR_TITLE { get; set; }

        public DateTime? SCPR_ACC_T { get; set; }

        public DateTime? SCPR_COMPENSATION_ST { get; set; }

        public DateTime? SCPR_COMPENSATION_ET { get; set; }

        [StringLength(50)]
        public string SCPR_SUBJECT { get; set; }

        [StringLength(50)]
        public string SCPR_DEDUCTIBLES { get; set; }

        [StringLength(50)]
        public string SCPR_TOTAL_AMOUNT { get; set; }

        [StringLength(50)]
        public string SCPR_FEE_AMOUNT { get; set; }

        [StringLength(150)]
        public string SCPR_NOTES { get; set; }

        [StringLength(50)]
        public string SCPR_NAME { get; set; }

        [StringLength(50)]
        public string SCPR_OTHERS { get; set; }

        [StringLength(150)]
        public string SCPR_ACC_CONTENT { get; set; }

        public DateTime? SCPR_CREATDATE { get; set; }

        public virtual SAFETY_BREAKRULE SAFETY_BREAKRULE { get; set; }
    }
}
