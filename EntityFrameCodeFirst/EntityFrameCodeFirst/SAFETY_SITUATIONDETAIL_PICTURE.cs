namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SITUATIONDETAIL_PICTURE
    {
        [Key]
        public int SDP_ID { get; set; }

        public int SDP_SD_ID { get; set; }

        [Column(TypeName = "image")]
        public byte[] SDP_PICT1 { get; set; }

        [Column(TypeName = "image")]
        public byte[] SDP_PICT2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] SDP_PICT3 { get; set; }
    }
}
