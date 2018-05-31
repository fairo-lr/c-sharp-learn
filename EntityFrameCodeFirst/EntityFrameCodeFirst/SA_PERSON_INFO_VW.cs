namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SA_PERSON_INFO_VW
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USR_ID { get; set; }

        [StringLength(50)]
        public string USR_NAME { get; set; }

        [StringLength(50)]
        public string DEP_NAME { get; set; }

        [StringLength(50)]
        public string PST_NAME { get; set; }

        [StringLength(255)]
        public string USR_PHONES { get; set; }

        [StringLength(50)]
        public string USR_COMPANY { get; set; }

        [StringLength(1)]
        public string USR_IS_LEAVE { get; set; }

        public int? USR_ATR_ID { get; set; }

        public DateTime? USR_IN_TM { get; set; }

        [StringLength(50)]
        public string USR_LOG_NAME { get; set; }
    }
}
