namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThroughputInReport")]
    public partial class ThroughputInReport
    {
        [Key]
        public int TIR_ID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TIR_DATE { get; set; }

        public double? TIR_AllTeu { get; set; }

        public double? TIR_TransferTeu { get; set; }

        public double? TIR_AllUnit { get; set; }

        public double? TIR_TransferUnit { get; set; }
    }
}
