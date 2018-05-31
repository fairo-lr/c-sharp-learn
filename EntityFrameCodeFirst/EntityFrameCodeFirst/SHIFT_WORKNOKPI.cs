namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIFT_WORKNOKPI
    {
        [Key]
        public int swk_id { get; set; }

        public DateTime? swk_date { get; set; }

        [StringLength(5)]
        public string swk_shift { get; set; }

        [StringLength(5)]
        public string swk_wrkno { get; set; }

        [StringLength(128)]
        public string swk_vsl1 { get; set; }

        [StringLength(128)]
        public string swk_vsl2 { get; set; }

        [StringLength(128)]
        public string swk_vsl3 { get; set; }

        [StringLength(128)]
        public string swk_vsl4 { get; set; }

        public int? swk_vsl1_unit { get; set; }

        public double? swk_vsl1_time { get; set; }

        public double? swk_crn1_time { get; set; }

        public int? swk_vsl2_unit { get; set; }

        public double? swk_vsl2_time { get; set; }

        public double? swk_crn2_time { get; set; }

        public int? swk_vsl3_unit { get; set; }

        public double? swk_vsl3_time { get; set; }

        public double? swk_crn3_time { get; set; }

        public int? swk_vsl4_unit { get; set; }

        public double? swk_vsl4_time { get; set; }

        public double? swk_crn4_time { get; set; }

        public double? taishi { get; set; }
    }
}
