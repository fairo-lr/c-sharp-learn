namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSON_CERTIFICATE_VW
    {
        [Key]
        public int PC_ID { get; set; }

        [StringLength(50)]
        public string PC_PERSON_DEPART { get; set; }

        public int? PC_PERSON_NO { get; set; }

        [StringLength(50)]
        public string PC_PERSON_NAME { get; set; }

        [StringLength(50)]
        public string PC_PERSON_DUTY { get; set; }

        [StringLength(50)]
        public string PC_CERTIFICATE_NAME { get; set; }

        [StringLength(50)]
        public string PC_CERTIFICATE_NO { get; set; }

        public DateTime? PC_GETTIME { get; set; }

        public DateTime? PC_STARTTIME { get; set; }

        public DateTime? PC_ENDTIME { get; set; }

        public DateTime? PC_CHKTIME { get; set; }

        [StringLength(50)]
        public string PC_ORGAN { get; set; }

        [StringLength(50)]
        public string PC_NODE { get; set; }

        [StringLength(50)]
        public string PC_CERTIFICATE_DEPART { get; set; }
    }
}
