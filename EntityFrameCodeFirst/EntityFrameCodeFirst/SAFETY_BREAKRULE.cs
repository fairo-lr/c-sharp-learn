namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_BREAKRULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAFETY_BREAKRULE()
        {
            SAFETY_ACCIDENT = new HashSet<SAFETY_ACCIDENT>();
            SAFETY_ACCIDENT_REPORT = new HashSet<SAFETY_ACCIDENT_REPORT>();
            SAFETY_ACCIDENT_STAFF = new HashSet<SAFETY_ACCIDENT_STAFF>();
            SAFETY_CLAIM_REPORT = new HashSet<SAFETY_CLAIM_REPORT>();
            SAFETY_COMPENSATION_REPORT = new HashSet<SAFETY_COMPENSATION_REPORT>();
        }

        [Key]
        public int SB_ID { get; set; }

        public DateTime? SB_DATE { get; set; }

        [StringLength(5)]
        public string SB_SHIFT { get; set; }

        public int? SB_NO { get; set; }

        [StringLength(100)]
        public string SB_NAME { get; set; }

        [StringLength(100)]
        public string SB_DEPART { get; set; }

        [StringLength(100)]
        public string SB_YARD { get; set; }

        [StringLength(32)]
        public string SB_MACHINE { get; set; }

        [StringLength(1024)]
        public string SB_CONTENT { get; set; }

        [StringLength(1024)]
        public string SB_RESULT { get; set; }

        public DateTime? SB_RECORDTM { get; set; }

        [StringLength(50)]
        public string SB_TYPE { get; set; }

        [StringLength(20)]
        public string SB_FINES { get; set; }

        [StringLength(50)]
        public string SB_NODE { get; set; }

        [StringLength(50)]
        public string SB_STATUS { get; set; }

        [StringLength(5)]
        public string SB_COMPENSATION_FLAG { get; set; }

        [StringLength(5)]
        public string SB_CLAIM_FLAG { get; set; }

        [StringLength(50)]
        public string BS_LVL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAFETY_ACCIDENT> SAFETY_ACCIDENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAFETY_ACCIDENT_REPORT> SAFETY_ACCIDENT_REPORT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAFETY_ACCIDENT_STAFF> SAFETY_ACCIDENT_STAFF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAFETY_CLAIM_REPORT> SAFETY_CLAIM_REPORT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAFETY_COMPENSATION_REPORT> SAFETY_COMPENSATION_REPORT { get; set; }
    }
}
