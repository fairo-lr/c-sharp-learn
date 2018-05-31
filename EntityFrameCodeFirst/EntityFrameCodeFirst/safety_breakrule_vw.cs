namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class safety_breakrule_vw
    {
        [StringLength(10)]
        public string 日期 { get; set; }

        [StringLength(5)]
        public string 工班 { get; set; }

        public int? 序号 { get; set; }

        [StringLength(100)]
        public string 人员 { get; set; }

        [StringLength(100)]
        public string 部门或单位 { get; set; }

        [StringLength(100)]
        public string 泊位或堆场 { get; set; }

        [StringLength(32)]
        public string 机械或设备 { get; set; }

        [StringLength(1024)]
        public string 违章简述 { get; set; }

        [StringLength(1024)]
        public string 处理结果 { get; set; }

        [StringLength(16)]
        public string 记录时间 { get; set; }

        [StringLength(50)]
        public string 类别 { get; set; }

        [StringLength(20)]
        public string 金额 { get; set; }

        [StringLength(50)]
        public string 备注 { get; set; }

        [StringLength(10)]
        public string 安监员 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SBID { get; set; }

        [StringLength(50)]
        public string 严重程度 { get; set; }
    }
}
