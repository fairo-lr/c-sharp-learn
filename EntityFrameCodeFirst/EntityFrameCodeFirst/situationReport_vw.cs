namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class situationReport_vw
    {
        public DateTime? 日期 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string 工班 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string 隐患代码 { get; set; }

        [StringLength(50)]
        public string 隐患类型 { get; set; }

        [StringLength(512)]
        public string 隐患陈诉 { get; set; }

        [StringLength(50)]
        public string 隐患地点 { get; set; }

        [StringLength(5)]
        public string 上报人员 { get; set; }

        [StringLength(5)]
        public string 上报部门 { get; set; }

        [StringLength(5)]
        public string 责任人员 { get; set; }

        [StringLength(5)]
        public string 责任部门 { get; set; }

        [StringLength(512)]
        public string 整改情况 { get; set; }

        [StringLength(50)]
        public string 完成情况 { get; set; }

        public DateTime? 记录时间 { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ID { get; set; }

        [StringLength(50)]
        public string 类型明细 { get; set; }
    }
}
