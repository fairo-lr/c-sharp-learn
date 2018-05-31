namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SITUATIONTYPE_DETAIL
    {
        [Key]
        public int STD_ID { get; set; }

        public int? STD_ST_ID { get; set; }

        [StringLength(50)]
        public string STD_CONTENT { get; set; }
    }
}
