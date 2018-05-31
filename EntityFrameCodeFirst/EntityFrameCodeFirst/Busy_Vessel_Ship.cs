namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_Vessel_Ship
    {
        [Key]
        public int Bvs_id { get; set; }

        public DateTime? Bvs_date { get; set; }

        [StringLength(20)]
        public string Bvs_day { get; set; }

        [StringLength(20)]
        public string Bvs_shift { get; set; }

        [StringLength(50)]
        public string Bvs_vnamecd { get; set; }

        [StringLength(100)]
        public string Bvs_vchname { get; set; }

        [StringLength(10)]
        public string Bvs_intrace { get; set; }

        public int? Bvs_shift_count { get; set; }

        public int? Bvs_vessel_count { get; set; }

        public DateTime? Bvs_PlanStartTime { get; set; }

        public DateTime? Bvs_PlanEndTime { get; set; }

        public DateTime? bvs_recordtime { get; set; }

        public DateTime? Bvs_PlanArriveTime { get; set; }

        public DateTime? Bvs_PlanDepartTime { get; set; }

        public int? Bvs_manShiftCount { get; set; }

        public int? bvs_workRoutes { get; set; }

        [StringLength(500)]
        public string bvs_note { get; set; }

        [StringLength(50)]
        public string bvs_voyage { get; set; }

        [StringLength(1)]
        public string bvs_bthdirc { get; set; }

        [StringLength(1)]
        public string bvs_berthno { get; set; }

        public int? bvs_startpst { get; set; }

        public int? bvs_endpst { get; set; }

        [StringLength(32)]
        public string sln_lne_rtcd { get; set; }
    }
}
