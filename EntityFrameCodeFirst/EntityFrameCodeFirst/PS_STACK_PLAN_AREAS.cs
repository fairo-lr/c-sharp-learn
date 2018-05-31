namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_STACK_PLAN_AREAS
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal SPR_SPL_YPLANID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal SPR_RANGEID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string SPR_PSTATUS { get; set; }

        [StringLength(1)]
        public string SPR_STACKRULE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string SPR_STBAY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string SPR_EDBAY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPR_GROUPNO { get; set; }

        [StringLength(1)]
        public string SPR_SPLITFG { get; set; }

        [StringLength(5)]
        public string SPR_EMPTID { get; set; }

        [StringLength(2)]
        public string SPR_STROW { get; set; }

        [StringLength(2)]
        public string SPR_EDROW { get; set; }

        public DateTime? SPR_LOGTIME { get; set; }

        public virtual PS_STACK_PLANS PS_STACK_PLANS { get; set; }
    }
}
