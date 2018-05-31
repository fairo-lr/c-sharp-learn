namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SITUATIONTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAFETY_SITUATIONTYPE()
        {
            SAFETY_SITUATIONDETAIL = new HashSet<SAFETY_SITUATIONDETAIL>();
        }

        [Key]
        public int ST_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ST_TYPE { get; set; }

        [StringLength(50)]
        public string ST_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAFETY_SITUATIONDETAIL> SAFETY_SITUATIONDETAIL { get; set; }
    }
}
