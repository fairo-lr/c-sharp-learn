namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Busy_yard_main_new
    {
        [Key]
        public int bym_id { get; set; }

        public DateTime? bym_date { get; set; }

        [StringLength(64)]
        public string bym_type { get; set; }

        [StringLength(1024)]
        public string bym_desc { get; set; }

        public DateTime? bym_inserttm { get; set; }
    }
}
