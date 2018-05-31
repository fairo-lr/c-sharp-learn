namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRAINING_MODEL
    {
        [Key]
        public int TM_ID { get; set; }

        public DateTime? TM_DATE { get; set; }

        [StringLength(50)]
        public string TM_HOUR { get; set; }

        [StringLength(50)]
        public string TM_ORAGN { get; set; }

        [StringLength(20)]
        public string TM_TEACHER { get; set; }

        [StringLength(50)]
        public string TM_PLACE { get; set; }

        [StringLength(100)]
        public string TM_POINT { get; set; }

        [StringLength(500)]
        public string TM_CONTEN { get; set; }

        [StringLength(200)]
        public string TM_RESULT { get; set; }

        [StringLength(50)]
        public string TM_CHECK { get; set; }

        public DateTime? TM_ENDTIME { get; set; }
    }
}
