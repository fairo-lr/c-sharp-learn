namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CERTIFICATE_ORGAN
    {
        [Key]
        public int CO_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CO_CERTIFICATE { get; set; }

        [Required]
        [StringLength(50)]
        public string CO_ORGAIN { get; set; }

        [StringLength(50)]
        public string CO_DEPART { get; set; }
    }
}
