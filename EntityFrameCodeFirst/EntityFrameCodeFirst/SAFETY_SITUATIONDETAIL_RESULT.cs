namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SITUATIONDETAIL_RESULT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SDR_SD_ID { get; set; }

        public string SDR_RESULT { get; set; }

        [StringLength(20)]
        public string SDR_RECORDER { get; set; }

        public DateTime? SDR_RECORD_TM { get; set; }
    }
}
