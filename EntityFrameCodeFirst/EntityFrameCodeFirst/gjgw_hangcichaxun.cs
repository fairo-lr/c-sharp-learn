namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gjgw_hangcichaxun
    {
        [StringLength(2)]
        public string TERCODE { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(35)]
        public string VLS_ENGNM { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal VOC_OCRRID { get; set; }

        [StringLength(8)]
        public string AGENTNAME { get; set; }

        [StringLength(1)]
        public string LIHUO { get; set; }

        [StringLength(4)]
        public string IEFG { get; set; }

        [StringLength(6)]
        public string VOYAGE { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal IEID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string VSLCODE { get; set; }

        [StringLength(8)]
        public string VSLNAME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string LNECODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string LENNAME { get; set; }

        [StringLength(8)]
        public string LNETYPE { get; set; }

        [StringLength(4)]
        public string NEIWAIMAO { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string Expr1 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string Expr2 { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(2)]
        public string 驳船否 { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string iz { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(2)]
        public string t { get; set; }

        [StringLength(5)]
        public string pp { get; set; }

        [StringLength(5)]
        public string np { get; set; }

        [StringLength(1)]
        public string VBT_ABERTHNO { get; set; }

        [StringLength(19)]
        public string VBT_PBTHTM { get; set; }

        [StringLength(19)]
        public string VOC_ARRIVETM { get; set; }

        [StringLength(19)]
        public string VBT_PBTHTMMM { get; set; }

        [StringLength(19)]
        public string VBT_ABTHTM { get; set; }

        [StringLength(19)]
        public string VIE_AWKSTTM { get; set; }

        [StringLength(19)]
        public string VIE_AWKENTM { get; set; }

        [StringLength(19)]
        public string VBT_PDPTTM { get; set; }

        [StringLength(19)]
        public string VBT_ADPTTM { get; set; }

        [StringLength(19)]
        public string VBT_PDPTTMM { get; set; }

        [StringLength(19)]
        public string VOC_DPORTTM { get; set; }

        [StringLength(10)]
        public string VBT_ADPTTMMM { get; set; }

        [StringLength(19)]
        public string VOC_RCVSTTM { get; set; }

        [StringLength(19)]
        public string VOC_RCVEDTM { get; set; }

        [StringLength(19)]
        public string VOC_TEREEDTM { get; set; }

        [StringLength(19)]
        public string VOC_RCVEDTMM { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1)]
        public string 抵港吃水 { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(1)]
        public string 离港吃水 { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string 是否使用拖轮 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string 引航标志 { get; set; }

        [StringLength(384)]
        public string PLANCNTR { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(1)]
        public string 倒箱计划作业数量 { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(1)]
        public string 长杆计划作业箱数 { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1)]
        public string 长杆起始贝位 { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(1)]
        public string 长杆结束贝位 { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(1)]
        public string 长杆实际作业箱数 { get; set; }

        public int? 外贸20空箱箱量 { get; set; }

        public int? 外贸40空箱箱量 { get; set; }

        public int? 外贸45空箱箱量 { get; set; }

        public int? 外贸20重箱箱量 { get; set; }

        public int? 外贸40重箱箱量 { get; set; }

        public int? 外贸45重箱箱量 { get; set; }

        public int? 外贸总箱货重 { get; set; }

        public int? 倒箱20空箱箱量 { get; set; }

        public int? 倒箱40空箱箱量 { get; set; }

        public int? 倒箱45空箱箱量 { get; set; }

        public int? 倒箱20重箱箱量 { get; set; }

        public int? 倒箱40重箱箱量 { get; set; }

        public int? 倒箱45重箱箱量 { get; set; }

        public int? 倒箱总箱货重 { get; set; }

        [StringLength(384)]
        public string 内贸20空箱箱量 { get; set; }

        [StringLength(384)]
        public string 内贸40空箱箱量 { get; set; }

        [StringLength(384)]
        public string 内贸45空箱箱量 { get; set; }

        [StringLength(384)]
        public string 内贸20重箱箱量 { get; set; }

        [StringLength(384)]
        public string 内贸40重箱箱量 { get; set; }

        [StringLength(384)]
        public string 内贸45重箱箱量 { get; set; }

        public int? 内贸总箱货重 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? 作业舱盖板数量 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? 作业工具箱数量 { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(1)]
        public string 备注1 { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(1)]
        public string 备注2 { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(1)]
        public string 备注3 { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(1)]
        public string 备注4 { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(1)]
        public string 备注5 { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(1)]
        public string 备注6 { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(1)]
        public string 备注7 { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(1)]
        public string 备注8 { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(1)]
        public string 备注9 { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(1)]
        public string 备注10 { get; set; }
    }
}
