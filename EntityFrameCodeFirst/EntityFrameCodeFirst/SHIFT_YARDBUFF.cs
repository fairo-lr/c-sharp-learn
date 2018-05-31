namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_YARDBUFF
    {
        public int ID { get; set; }

        [StringLength(2)]
        public string SYB_AREA { get; set; }

        [StringLength(2)]
        public string SYB_STBAY { get; set; }

        [StringLength(2)]
        public string SYB_EDBAY { get; set; }

        [StringLength(1)]
        public string SYB_ISDELETED { get; set; }

        public DateTime? SYB_ADDTM { get; set; }

        [StringLength(50)]
        public string SYB_ADDUSR { get; set; }

        public DateTime? SYB_DELTM { get; set; }

        [StringLength(50)]
        public string SYB_DELUSR { get; set; }
    }
}
