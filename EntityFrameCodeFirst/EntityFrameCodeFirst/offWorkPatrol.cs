namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("offWorkPatrol")]
    public partial class offWorkPatrol
    {
        public int id { get; set; }

        public DateTime? theTM { get; set; }

        [StringLength(50)]
        public string events { get; set; }

        [StringLength(20)]
        public string recorder { get; set; }

        [StringLength(2048)]
        public string contents { get; set; }

        [StringLength(150)]
        public string prosDep { get; set; }

        [StringLength(2048)]
        public string prosResu { get; set; }

        [Column(TypeName = "image")]
        public byte[] pict1 { get; set; }

        [Column(TypeName = "image")]
        public byte[] pict2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] pict3 { get; set; }

        public DateTime? recordTM { get; set; }

        public DateTime? updateTM { get; set; }

        [StringLength(20)]
        public string handler { get; set; }

        [StringLength(20)]
        public string refnumber { get; set; }

        [StringLength(50)]
        public string pict1Url { get; set; }

        [StringLength(50)]
        public string pict2Url { get; set; }

        [StringLength(50)]
        public string pict3Url { get; set; }

        [StringLength(200)]
        public string conclusion { get; set; }
    }
}
