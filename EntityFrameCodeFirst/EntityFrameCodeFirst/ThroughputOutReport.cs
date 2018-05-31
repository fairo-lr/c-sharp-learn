namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThroughputOutReport")]
    public partial class ThroughputOutReport
    {
        [Key]
        public int TOR_ID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TOR_Date { get; set; }

        public double? TOR_AllTeu { get; set; }

        public double? TOR_TransferTeu { get; set; }

        public double? TOR_AllUnit { get; set; }

        public double? TOR_TransferUnit { get; set; }
    }
}
