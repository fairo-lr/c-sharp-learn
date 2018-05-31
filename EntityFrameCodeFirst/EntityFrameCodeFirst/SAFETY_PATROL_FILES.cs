namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_PATROL_FILES
    {
        [Key]
        public int SPF_ID { get; set; }

        [StringLength(1024)]
        public string SPF_FILENAME { get; set; }

        public DateTime? SPF_DATE_ADDED { get; set; }

        [StringLength(50)]
        public string SPF_IMPORT_USER { get; set; }
    }
}
