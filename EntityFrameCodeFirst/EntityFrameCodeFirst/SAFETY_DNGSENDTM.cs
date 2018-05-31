namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_DNGSENDTM
    {
        public long id { get; set; }

        [StringLength(512)]
        public string filename { get; set; }

        public DateTime? sendtm { get; set; }
    }
}
