namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_Vessel_Plan_vw
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bvp_id { get; set; }

        public DateTime? 日期 { get; set; }

        [StringLength(20)]
        public string 天数 { get; set; }

        [StringLength(20)]
        public string 工班 { get; set; }

        [StringLength(10)]
        public string 班组日期 { get; set; }

        public double? 计划查验 { get; set; }

        public double? 计划查验归位 { get; set; }

        public double? 计划熏蒸 { get; set; }

        public double? 计划转栈 { get; set; }

        public double? 计划进场 { get; set; }

        public double? 计划出场 { get; set; }

        public double? 查验 { get; set; }

        public double? 查验归位 { get; set; }

        public double? 熏蒸 { get; set; }

        public double? 转栈 { get; set; }

        public double? 进场 { get; set; }

        public double? 出场 { get; set; }

        public double? 计划内贸进场 { get; set; }

        public double? 计划内贸出场 { get; set; }
    }
}
