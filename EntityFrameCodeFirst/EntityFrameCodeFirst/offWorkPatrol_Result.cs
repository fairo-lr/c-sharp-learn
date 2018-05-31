namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class offWorkPatrol_Result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OWPR_OWP_ID { get; set; }

        [StringLength(10)]
        public string OWPR_TYPE { get; set; }

        [StringLength(2048)]
        public string OWPR_RESULT { get; set; }

        [StringLength(20)]
        public string OWPR_RECORDER { get; set; }

        public DateTime? OWPR_RECORD_TM { get; set; }
    }
}
