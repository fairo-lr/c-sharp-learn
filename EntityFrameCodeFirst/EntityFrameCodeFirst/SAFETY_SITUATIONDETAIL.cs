namespace EntityFrameCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAFETY_SITUATIONDETAIL
    {
        [Key]
        public int SD_ID { get; set; }

        public DateTime? SD_DATE { get; set; }

        [StringLength(5)]
        public string SD_SHIFT { get; set; }

        public int? SD_ST_ID { get; set; }

        public int? SD_STD_ID { get; set; }

        [StringLength(10)]
        public string SD_HIDDANGER_FLAG { get; set; }

        [StringLength(512)]
        public string SD_SITUATIONDETAIL { get; set; }

        [StringLength(5)]
        public string SD_FINDPERSION { get; set; }

        [StringLength(5)]
        public string SD_FINDDEPART { get; set; }

        [StringLength(5)]
        public string SD_DUTYPERSION { get; set; }

        [StringLength(5)]
        public string SD_DUTYDEPART { get; set; }

        [StringLength(512)]
        public string SD_CHANGE { get; set; }

        [StringLength(50)]
        public string SD_FINAL { get; set; }

        public DateTime? SD_RECORDTM { get; set; }

        [StringLength(50)]
        public string SD_PLACE { get; set; }

        [StringLength(50)]
        public string SD_HIDDANGER_CHECKTYPE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SD_DEADLINE { get; set; }

        [StringLength(200)]
        public string SD_CONCLUSION { get; set; }

        public virtual SAFETY_SITUATIONTYPE SAFETY_SITUATIONTYPE { get; set; }
    }
}
