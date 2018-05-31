namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BUSY_MACHINE_TIME
    {
        [Key]
        public int bmt_id { get; set; }

        public DateTime? bmt_date { get; set; }

        [StringLength(5)]
        public string bmt_day { get; set; }

        [StringLength(5)]
        public string bmt_hour { get; set; }

        public double? bmt_number { get; set; }

        public double? bmt_inOut { get; set; }

        public double? bmt_restow { get; set; }

        public double? bmt_transfer { get; set; }

        public double? bmt_vessel { get; set; }
    }
}
