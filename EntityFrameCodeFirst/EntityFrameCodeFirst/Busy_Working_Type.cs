namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_Working_Type
    {
        [Key]
        public int Bvt_id { get; set; }

        public DateTime? Bvt_date { get; set; }

        [StringLength(20)]
        public string Bvt_day { get; set; }

        [StringLength(20)]
        public string Bvt_shift { get; set; }

        [StringLength(100)]
        public string Bvt_CntrCstmnm { get; set; }

        [StringLength(10)]
        public string Bvt_CntrOpercd { get; set; }

        [StringLength(10)]
        public string Bvt_CntrSize { get; set; }

        [StringLength(10)]
        public string Bvt_CntrHeight { get; set; }

        [StringLength(10)]
        public string Bvt_CntrIsocd { get; set; }

        public DateTime? Bvt_PlanSttm { get; set; }

        public DateTime? Bvt_PlanEdtm { get; set; }

        public double? Bvt_PlanNumber { get; set; }

        public double? Bvt_Number { get; set; }

        [StringLength(50)]
        public string Bvt_Rank { get; set; }

        public DateTime? bvt_recordtime { get; set; }

        public int? bvp_PlanID { get; set; }
    }
}
