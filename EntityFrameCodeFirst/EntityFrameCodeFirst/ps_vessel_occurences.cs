namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ps_vessel_occurences
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal voc_id { get; set; }

        [StringLength(50)]
        public string voc_name { get; set; }

        [StringLength(50)]
        public string voc_ivoyage { get; set; }

        public DateTime? voc_logtime { get; set; }
    }
}
