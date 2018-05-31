namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferDataSet")]
    public partial class TransferDataSet
    {
        [Key]
        public int TF_ID { get; set; }

        [StringLength(20)]
        public string TF_VNAME { get; set; }

        [StringLength(20)]
        public string TF_VOYAGE { get; set; }

        [StringLength(50)]
        public string TF_CSTATUS { get; set; }

        public DateTime? TF_ETIME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TF_E20 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TF_E40 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TF_E45 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TF_F20 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TF_F40 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TF_F45 { get; set; }

        [StringLength(200)]
        public string TF_CONTENT { get; set; }

        [StringLength(500)]
        public string TF_NOTE { get; set; }
    }
}
