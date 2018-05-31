namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_PLANE
    {
        [Key]
        public int SP_ID { get; set; }

        public DateTime? SP_DATE { get; set; }

        [StringLength(5)]
        public string SP_SHIFT { get; set; }

        public double? SP_SHIFT_HOUR { get; set; }

        public double? SP_SHIFT_PERHOUR { get; set; }

        public double? SP_SHIFT_COUNT { get; set; }

        [StringLength(50)]
        public string SP_SHIFT_USER { get; set; }

        public DateTime? SP_SHIFT_TIME_ADDED { get; set; }

        public DateTime? SP_SHIFT_TIME_UPDATED { get; set; }
    }
}
