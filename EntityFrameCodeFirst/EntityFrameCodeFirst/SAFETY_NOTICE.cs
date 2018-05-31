namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_NOTICE
    {
        public int ID { get; set; }

        [StringLength(1024)]
        public string Contents { get; set; }

        public DateTime? AddTm { get; set; }

        [StringLength(1)]
        public string IsDelete { get; set; }

        [StringLength(50)]
        public string AddUser { get; set; }

        public DateTime? ModTm { get; set; }

        [StringLength(50)]
        public string ModUser { get; set; }
    }
}
