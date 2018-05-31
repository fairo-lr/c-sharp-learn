namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SUPERVISION_JOB
    {
        [Key]
        public int SJ_ID { get; set; }

        [StringLength(50)]
        public string SJ_NAME { get; set; }

        [StringLength(200)]
        public string SJ_CONTENT { get; set; }

        [StringLength(1)]
        public string SJ_TYPE { get; set; }
    }
}
