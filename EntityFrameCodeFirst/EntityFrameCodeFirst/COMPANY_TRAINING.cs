namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPANY_TRAINING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPANY_TRAINING()
        {
            PERSON_TRAINING = new HashSet<PERSON_TRAINING>();
            PERSON_TRAINING1 = new HashSet<PERSON_TRAINING>();
        }

        [Key]
        public int CT_ID { get; set; }

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

        public DateTime? CT_ENDTIME { get; set; }

        [StringLength(512)]
        public string CT_NODE { get; set; }

        public double? CT_COST { get; set; }

        public string CT_FILES { get; set; }

        [StringLength(5)]
        public string CT_DEP { get; set; }

        [StringLength(50)]
        public string CT_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSON_TRAINING> PERSON_TRAINING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSON_TRAINING> PERSON_TRAINING1 { get; set; }
    }
}
