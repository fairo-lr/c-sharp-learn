namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SUPERVISION_PROJECT
    {
        [Key]
        public int SP_ID { get; set; }

        [StringLength(20)]
        public string SP_NAME { get; set; }

        [StringLength(20)]
        public string SP_SITE { get; set; }

        public DateTime SP_STIME { get; set; }

        public DateTime SP_ETIME { get; set; }

        [StringLength(20)]
        public string SP_COMPANY { get; set; }

        public DateTime? SP_RECORDTIME { get; set; }

        [StringLength(1)]
        public string SP_TYPE { get; set; }
    }
}
