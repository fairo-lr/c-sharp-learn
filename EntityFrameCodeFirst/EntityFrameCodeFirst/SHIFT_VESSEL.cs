namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_VESSEL
    {
        [Key]
        public int SV_ID { get; set; }

        public DateTime SV_DATE { get; set; }

        [Required]
        [StringLength(5)]
        public string SV_SHIFT { get; set; }

        [StringLength(5)]
        public string SV_WKNO { get; set; }

        [StringLength(20)]
        public string SV_VNAMECD { get; set; }

        [StringLength(20)]
        public string SV_VOYAGE { get; set; }

        [StringLength(20)]
        public string SV_SLINE { get; set; }

        public DateTime? SV_ABTHTM { get; set; }

        public DateTime? SV_OPSTTM { get; set; }

        public DateTime? SV_OPEDTM { get; set; }

        public DateTime? SV_ADPTTM { get; set; }

        public int? SV_CRANENUM { get; set; }

        public int? SV_TRUCKNUM { get; set; }

        public int? SV_LOADUNI { get; set; }

        public int? SV_DISUNI { get; set; }

        public double? SV_GORTIME { get; set; }

        public double? SV_PRETIME { get; set; }

        public double? SV_AVATIME { get; set; }

        public double? SV_GOALTIME { get; set; }

        public int? SV_HATCH { get; set; }

        [StringLength(1024)]
        public string SV_NOTE { get; set; }

        [StringLength(1)]
        public string SV_FINALSTATE { get; set; }

        [StringLength(255)]
        public string SV_VDELAY_HOURS { get; set; }

        [StringLength(255)]
        public string SV_GSTAN_HOURS { get; set; }

        [StringLength(1)]
        public string SV_ISCARGO { get; set; }

        [StringLength(20)]
        public string SV_IEPLANE { get; set; }

        public DateTime? SV_FINALTIME { get; set; }

        public double? SV_ALLGORTIME { get; set; }

        [StringLength(1)]
        public string SV_ISINTERTRADE { get; set; }

        public DateTime? SV_PBTHTM { get; set; }

        public DateTime? SV_PDPTTM { get; set; }

        public int? SV_PWRKROTE { get; set; }

        public int? SV_CKEMPTARRI { get; set; }

        public int? SV_CKEMPTALL { get; set; }

        public int? SV_UNLOADARRI { get; set; }

        public int? SV_UNLOADALL { get; set; }

        public double? SV_NET_GORTIME { get; set; }

        public double? SV_NET_GOALTIME { get; set; }

        public int? SV_VOCID { get; set; }

        [StringLength(1)]
        public string SV_LNE_INTERNALFG { get; set; }
    }
}
