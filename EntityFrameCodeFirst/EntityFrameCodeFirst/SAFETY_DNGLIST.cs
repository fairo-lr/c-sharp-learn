namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_DNGLIST
    {
        public long id { get; set; }

        public int? cntrid { get; set; }

        [StringLength(50)]
        public string ylocation { get; set; }

        [StringLength(50)]
        public string cntrno { get; set; }

        [StringLength(50)]
        public string cszie { get; set; }

        [StringLength(50)]
        public string cheight { get; set; }

        [StringLength(50)]
        public string ctype { get; set; }

        [StringLength(50)]
        public string ccopre { get; set; }

        [StringLength(50)]
        public string cstatus { get; set; }

        [StringLength(50)]
        public string vname { get; set; }

        [StringLength(50)]
        public string voyage { get; set; }

        [StringLength(2)]
        public string viefg { get; set; }

        public int? cweight { get; set; }

        [StringLength(50)]
        public string dngtype { get; set; }

        [StringLength(50)]
        public string dngno { get; set; }

        public DateTime? intm { get; set; }

        public double? inday { get; set; }

        [StringLength(512)]
        public string pname { get; set; }

        [StringLength(50)]
        public string contact { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(512)]
        public string solution { get; set; }

        [StringLength(512)]
        public string attention { get; set; }

        public DateTime? date1 { get; set; }

        [StringLength(50)]
        public string mduser1 { get; set; }

        public DateTime? date2 { get; set; }

        [StringLength(50)]
        public string mduser2 { get; set; }

        [StringLength(50)]
        public string agent { get; set; }
    }
}
