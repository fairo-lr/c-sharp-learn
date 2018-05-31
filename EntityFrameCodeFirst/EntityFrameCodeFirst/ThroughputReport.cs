namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThroughputReport")]
    public partial class ThroughputReport
    {
        [Key]
        public int TR_ID { get; set; }

        public DateTime? TR_ETime { get; set; }

        [StringLength(50)]
        public string TR_VesselName { get; set; }

        [StringLength(50)]
        public string TR_VesselVoyage { get; set; }

        public int? TR_Restow { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TR_TEU { get; set; }

        public int? TR_UNIT { get; set; }

        public bool? TR_Bulk { get; set; }

        public bool? TR_Intranal { get; set; }

        [StringLength(1)]
        public string TR_EFFG { get; set; }

        [StringLength(4)]
        public string TR_SIZE { get; set; }
    }
}
