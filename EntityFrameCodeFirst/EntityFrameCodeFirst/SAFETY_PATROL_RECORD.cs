namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_PATROL_RECORD
    {
        [Key]
        [Column(Order = 0)]
        public int SPR_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SPR_SPF_ID { get; set; }

        public DateTime? SPR_DATETIME { get; set; }

        [StringLength(128)]
        public string SPR_POINT { get; set; }

        [StringLength(128)]
        public string SPR_DESC { get; set; }

        [StringLength(128)]
        public string SPR_LINE { get; set; }
    }
}
