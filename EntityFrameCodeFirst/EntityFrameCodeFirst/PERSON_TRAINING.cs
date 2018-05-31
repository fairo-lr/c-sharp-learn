namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSON_TRAINING
    {
        [Key]
        public int PT_ID { get; set; }

        public int? PT_CT_ID { get; set; }

        public int? PT_PERSON_NO { get; set; }

        [StringLength(512)]
        public string PT_Node { get; set; }

        [StringLength(512)]
        public string PT_OTHERS { get; set; }

        public virtual COMPANY_TRAINING COMPANY_TRAINING { get; set; }

        public virtual COMPANY_TRAINING COMPANY_TRAINING1 { get; set; }
    }
}
