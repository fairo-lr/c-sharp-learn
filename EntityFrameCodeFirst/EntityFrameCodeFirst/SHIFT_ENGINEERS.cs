namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_ENGINEERS
    {
        [Key]
        public int SE_ID { get; set; }

        public DateTime? SE_DATE { get; set; }

        [StringLength(5)]
        public string SE_SHIFT { get; set; }

        [StringLength(32)]
        public string SE_MONITOR { get; set; }

        public int? SE_PEOPLES { get; set; }

        [StringLength(1024)]
        public string SE_REMARK { get; set; }

        public DateTime? SE_CREATETM { get; set; }

        public DateTime? SE_SUBMITTM { get; set; }
    }
}
