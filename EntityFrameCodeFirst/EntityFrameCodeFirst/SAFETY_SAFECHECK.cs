namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SAFECHECK
    {
        [Key]
        public int SC_ID { get; set; }

        [StringLength(200)]
        public string SC_CONTENT { get; set; }

        [StringLength(50)]
        public string SC_SITE { get; set; }

        [StringLength(200)]
        public string SC_DEMAND { get; set; }

        [StringLength(20)]
        public string SC_DEPART { get; set; }

        [StringLength(100)]
        public string SC_STATUS { get; set; }

        [StringLength(200)]
        public string SC_RESULT { get; set; }

        [StringLength(200)]
        public string SC_NOTE { get; set; }

        public DateTime? SC_CREATTM { get; set; }

        public DateTime? SC_DEALTM { get; set; }

        public DateTime? SC_DEADLINE { get; set; }

        [StringLength(100)]
        public string SC_PICT1 { get; set; }

        [StringLength(100)]
        public string SC_PICT2 { get; set; }

        [StringLength(100)]
        public string SC_PICT3 { get; set; }
    }
}
