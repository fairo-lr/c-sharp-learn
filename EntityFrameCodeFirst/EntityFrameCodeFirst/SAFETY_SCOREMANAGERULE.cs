namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SCOREMANAGERULE
    {
        [Key]
        public int SMR_ID { get; set; }

        [StringLength(200)]
        public string SMR_NAME { get; set; }

        [StringLength(20)]
        public string SMR_SCOREROLE { get; set; }

        [StringLength(150)]
        public string SMR_CONTENT { get; set; }

        public int? SMR_SCORE { get; set; }

        [StringLength(100)]
        public string SMR_NOTES { get; set; }

        public int? SMR_MONEY { get; set; }
    }
}
