namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_VESSEL
    {
        [Key]
        public int SV_ID { get; set; }

        public DateTime? SV_DATE { get; set; }

        [StringLength(5)]
        public string SV_SHIFT { get; set; }

        [StringLength(20)]
        public string SV_VNAMECD { get; set; }

        [StringLength(20)]
        public string SV_VOYAGE { get; set; }

        [StringLength(20)]
        public string SV_SLINE { get; set; }

        [StringLength(20)]
        public string SV_PORT { get; set; }

        [StringLength(20)]
        public string SV_ABTHTM { get; set; }

        [StringLength(20)]
        public string SV_OPSTTM { get; set; }

        [StringLength(20)]
        public string SV_OPEDTM { get; set; }

        [StringLength(20)]
        public string SV_ADPTTM { get; set; }

        [StringLength(128)]
        public string SV_ROPEBINDTM { get; set; }

        [StringLength(128)]
        public string SV_LADERDOWNTM { get; set; }

        [StringLength(128)]
        public string SV_INSPECARRITM { get; set; }

        [StringLength(128)]
        public string SV_INSPECUPTM { get; set; }

        [StringLength(128)]
        public string SV_INSPECDOWNTM { get; set; }

        [StringLength(128)]
        public string SV_WORKERUPTM { get; set; }

        public DateTime? SV_RECORDTM { get; set; }

        [StringLength(128)]
        public string SV_WORKERDOWN { get; set; }

        [StringLength(20)]
        public string SV_NEXTPORT { get; set; }
    }
}
