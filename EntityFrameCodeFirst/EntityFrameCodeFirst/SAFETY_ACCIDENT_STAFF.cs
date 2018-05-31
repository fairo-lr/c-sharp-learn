namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_ACCIDENT_STAFF
    {
        [Key]
        public int SAS_ID { get; set; }

        public int? SAS_SB_ID { get; set; }

        public int? SAS_SD_ID { get; set; }

        public int? SAS_PERSON_NO { get; set; }

        [StringLength(50)]
        public string SAS_PERSON_NAME { get; set; }

        [StringLength(50)]
        public string SAS_DEPART { get; set; }

        [StringLength(50)]
        public string SAS_MACHINE { get; set; }

        [StringLength(50)]
        public string SAS_COMPANY { get; set; }

        [StringLength(150)]
        public string SAS_DISPOSE { get; set; }

        [StringLength(20)]
        public string SAS_FINE_TYPE { get; set; }

        public int? SAS_FINE { get; set; }

        [StringLength(20)]
        public string SAS_SMR_NAME { get; set; }

        [StringLength(50)]
        public string SAS_ROLES { get; set; }

        public int? SAS_SCORE { get; set; }

        public int? SAS_SMR_ID { get; set; }

        [StringLength(50)]
        public string SAS_NOTE { get; set; }

        public virtual SAFETY_BREAKRULE SAFETY_BREAKRULE { get; set; }
    }
}
