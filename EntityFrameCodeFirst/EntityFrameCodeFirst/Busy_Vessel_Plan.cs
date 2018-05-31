namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_Vessel_Plan
    {
        [Key]
        public int Bvp_id { get; set; }

        public DateTime? Bvp_date { get; set; }

        [StringLength(20)]
        public string Bvp_day { get; set; }

        [StringLength(20)]
        public string Bvp_shift { get; set; }

        public double? Bvp_check_plan { get; set; }

        public double? Bvp_Checkback_plan { get; set; }

        public double? bvp_suffocation_plan { get; set; }

        public double? bvp_transfer_plan { get; set; }

        public double? bvp_in_plan { get; set; }

        public double? bvp_out_plan { get; set; }

        public double? bvp_innerIn_plan { get; set; }

        public double? bvp_innerOut_plan { get; set; }

        public double? Bvp_check { get; set; }

        public double? Bvp_Checkback { get; set; }

        public double? bvp_suffocation { get; set; }

        public double? bvp_transfer { get; set; }

        public double? bvp_in { get; set; }

        public double? bvp_out { get; set; }

        public DateTime? bvp_recordtime { get; set; }

        public int? bvp_PlanID { get; set; }

        public double? bvp_emptyMove_plan { get; set; }

        public double? bvp_shifts_plan { get; set; }

        public double? bvp_innerShifts_plan { get; set; }

        public double? bvp_check_plan_m { get; set; }

        public double? bvp_checkback_plan_m { get; set; }

        public double? bvp_shuffocation_plan_m { get; set; }

        public double? bvp_ransfer_plan_m { get; set; }

        public double? bvp_in_plan_m { get; set; }

        public double? bvp_out_plan_m { get; set; }

        public double? bvp_innerIn_plan_m { get; set; }

        public double? bvp_innerOut_plan_m { get; set; }

        public double? bvp_eptMov_plan_m { get; set; }

        public double? bvp_shifts_plan_m { get; set; }

        public double? bvp_innerShifts_plan_m { get; set; }
    }
}
