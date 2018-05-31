namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_ACCIDENT
    {
        [Key]
        public int SA_ID { get; set; }

        public DateTime? SA_DATE { get; set; }

        [StringLength(5)]
        public string SA_SHIFT { get; set; }

        [StringLength(128)]
        public string SA_HAPPENTM { get; set; }

        [StringLength(1024)]
        public string SA_CONTENT { get; set; }

        public DateTime? SA_RECORDTM { get; set; }

        [StringLength(50)]
        public string SA_TYPE { get; set; }

        [StringLength(256)]
        public string SA_PICTURE { get; set; }

        [StringLength(256)]
        public string SA_PICTURE2 { get; set; }

        [StringLength(256)]
        public string SA_PICTURE3 { get; set; }

        [StringLength(1024)]
        public string SA_NODE { get; set; }

        public int? SA_SB_ID { get; set; }

        public virtual SAFETY_BREAKRULE SAFETY_BREAKRULE { get; set; }
    }
}
