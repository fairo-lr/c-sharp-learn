namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_Working_Type_Vw
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bvt_id { get; set; }

        public DateTime? 日期 { get; set; }

        [StringLength(10)]
        public string 工班日期 { get; set; }

        [StringLength(20)]
        public string 天数 { get; set; }

        [StringLength(20)]
        public string 工班 { get; set; }

        [StringLength(100)]
        public string 承运人 { get; set; }

        public DateTime? 计划开始时间 { get; set; }

        public DateTime? 计划结束时间 { get; set; }

        public double? 计划数量 { get; set; }

        public double? 实际数量 { get; set; }

        [StringLength(50)]
        public string 等级 { get; set; }
    }
}
