namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MACHINE_BREAKDOWNS
    {
        [Key]
        public int MB_ID { get; set; }

        public DateTime MB_DATE { get; set; }

        [StringLength(5)]
        public string MB_SHIFT { get; set; }

        [StringLength(5)]
        public string MB_WKNO { get; set; }

        [Required]
        [StringLength(10)]
        public string MB_MCHNO { get; set; }

        [StringLength(255)]
        public string MB_BRKDWNRS { get; set; }

        public DateTime? MB_BRKDWNSTTM { get; set; }

        public DateTime? MB_BRKDWNENTM { get; set; }

        [StringLength(26)]
        public string MB_MCHSTATUS { get; set; }

        [StringLength(4)]
        public string MB_MCHWORK { get; set; }

        [StringLength(1)]
        public string MB_FINALSTATE { get; set; }

        public DateTime? MB_FINALTIME { get; set; }
    }
}
