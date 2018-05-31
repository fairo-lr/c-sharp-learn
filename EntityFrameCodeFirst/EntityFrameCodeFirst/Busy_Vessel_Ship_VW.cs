namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_Vessel_Ship_VW
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bvs_id { get; set; }

        public DateTime? 日期 { get; set; }

        [StringLength(20)]
        public string 天数 { get; set; }

        [StringLength(20)]
        public string 工班 { get; set; }

        [StringLength(50)]
        public string 船代码 { get; set; }

        [StringLength(100)]
        public string 中文船名 { get; set; }

        [StringLength(10)]
        public string 内贸标志 { get; set; }

        public DateTime? 计划开始时间 { get; set; }

        public DateTime? 计划结束时间 { get; set; }

        public DateTime? 计划靠泊时间 { get; set; }

        public DateTime? 计划离泊时间 { get; set; }

        public int? 当班箱量 { get; set; }

        public int? 剩余箱量 { get; set; }

        public int? 船箱量 { get; set; }
    }
}
