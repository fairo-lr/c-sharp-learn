namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPANY_PERSON_TRAINING_VW
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PT_ID { get; set; }

        [StringLength(50)]
        public string USR_NAME { get; set; }

        [StringLength(50)]
        public string DEP_NAME { get; set; }

        public int? PT_PERSON_NO { get; set; }

        [StringLength(512)]
        public string PT_Node { get; set; }

        public int? CT_ID { get; set; }

        public DateTime? CT_DATE { get; set; }

        [StringLength(50)]
        public string CT_HOUR { get; set; }

        [StringLength(50)]
        public string CT_ORAGN { get; set; }

        [StringLength(20)]
        public string CT_TEACHER { get; set; }

        [StringLength(50)]
        public string CT_PLACE { get; set; }

        [StringLength(100)]
        public string CT_POINT { get; set; }

        [StringLength(500)]
        public string CT_CONTEN { get; set; }

        [StringLength(200)]
        public string CT_RESULT { get; set; }

        [StringLength(50)]
        public string CT_CHECK { get; set; }

        [StringLength(1)]
        public string USR_IS_LEAVE { get; set; }
    }
}
