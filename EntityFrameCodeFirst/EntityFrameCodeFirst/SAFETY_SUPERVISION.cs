namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SUPERVISION
    {
        [Key]
        public int SPV_ID { get; set; }

        public DateTime? SPV_SI_DATE { get; set; }

        [StringLength(5)]
        public string SPV_SI_SHIFT { get; set; }

        public int? SPV_SP_ID { get; set; }

        [StringLength(20)]
        public string SPV_SJ_ID { get; set; }

        [StringLength(200)]
        public string SPV_NOTES { get; set; }

        public DateTime? SPV_RECORD_TIME { get; set; }
    }
}
