namespace EntityFrameCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Control : DbContext
    {
        public Control()
            : base("name=Control")
        {
        }

        public virtual DbSet<Busy_Bay> Busy_Bay { get; set; }
        public virtual DbSet<Busy_Information> Busy_Information { get; set; }
        public virtual DbSet<BUSY_MACHINE_TIME> BUSY_MACHINE_TIME { get; set; }
        public virtual DbSet<Busy_Vessel_Plan> Busy_Vessel_Plan { get; set; }
        public virtual DbSet<Busy_Vessel_Ship> Busy_Vessel_Ship { get; set; }
        public virtual DbSet<Busy_Working_Type> Busy_Working_Type { get; set; }
        public virtual DbSet<CERTIFICATE_ORGAN> CERTIFICATE_ORGAN { get; set; }
        public virtual DbSet<COMPANY_TRAINING> COMPANY_TRAINING { get; set; }
        public virtual DbSet<MACHINE_BREAKDOWNS> MACHINE_BREAKDOWNS { get; set; }
        public virtual DbSet<PERSON_CERTIFICATE> PERSON_CERTIFICATE { get; set; }
        public virtual DbSet<PERSON_TRAINING> PERSON_TRAINING { get; set; }
        public virtual DbSet<PS_STACK_PLANS> PS_STACK_PLANS { get; set; }
        public virtual DbSet<SAFETY_ACCIDENT> SAFETY_ACCIDENT { get; set; }
        public virtual DbSet<SAFETY_BREAKRULE> SAFETY_BREAKRULE { get; set; }
        public virtual DbSet<SAFETY_NOTICE> SAFETY_NOTICE { get; set; }
        public virtual DbSet<SAFETY_SITUATIONDETAIL> SAFETY_SITUATIONDETAIL { get; set; }
        public virtual DbSet<SAFETY_SITUATIONDETAIL_PICTURE> SAFETY_SITUATIONDETAIL_PICTURE { get; set; }
        public virtual DbSet<SAFETY_SITUATIONDETAIL_RESULT> SAFETY_SITUATIONDETAIL_RESULT { get; set; }
        public virtual DbSet<SAFETY_SITUATIONTYPE> SAFETY_SITUATIONTYPE { get; set; }
        public virtual DbSet<SAFETY_SITUATIONTYPE_DETAIL> SAFETY_SITUATIONTYPE_DETAIL { get; set; }
        public virtual DbSet<SAFETY_SUPERVISION_JOB> SAFETY_SUPERVISION_JOB { get; set; }
        public virtual DbSet<SAFETY_SUPERVISION_PROJECT> SAFETY_SUPERVISION_PROJECT { get; set; }
        public virtual DbSet<SHIFT_DUTY> SHIFT_DUTY { get; set; }
        public virtual DbSet<SHIFT_INFORMATION> SHIFT_INFORMATION { get; set; }
        public virtual DbSet<SHIFT_MACHINE_WORK> SHIFT_MACHINE_WORK { get; set; }
        public virtual DbSet<SHIFT_VESSEL> SHIFT_VESSEL { get; set; }
        public virtual DbSet<SHIFT_WORKNOKPI> SHIFT_WORKNOKPI { get; set; }
        public virtual DbSet<SHIFT_WORKS> SHIFT_WORKS { get; set; }
        public virtual DbSet<SHIFT_YARDBUFF> SHIFT_YARDBUFF { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThroughputInReport> ThroughputInReports { get; set; }
        public virtual DbSet<ThroughputOutReport> ThroughputOutReports { get; set; }
        public virtual DbSet<ThroughputReport> ThroughputReports { get; set; }
        public virtual DbSet<TRAINING_MODEL> TRAINING_MODEL { get; set; }
        public virtual DbSet<Busy_yard_main_new> Busy_yard_main_new { get; set; }
        public virtual DbSet<offWorkPatrol> offWorkPatrols { get; set; }
        public virtual DbSet<offWorkPatrol_Result> offWorkPatrol_Result { get; set; }
        public virtual DbSet<PS_STACK_PLAN_AREAS> PS_STACK_PLAN_AREAS { get; set; }
        public virtual DbSet<ps_vessel_occurences> ps_vessel_occurences { get; set; }
        public virtual DbSet<SAFETY_ACCIDENT_REPORT> SAFETY_ACCIDENT_REPORT { get; set; }
        public virtual DbSet<SAFETY_ACCIDENT_STAFF> SAFETY_ACCIDENT_STAFF { get; set; }
        public virtual DbSet<SAFETY_CLAIM_REPORT> SAFETY_CLAIM_REPORT { get; set; }
        public virtual DbSet<SAFETY_COMPENSATION_REPORT> SAFETY_COMPENSATION_REPORT { get; set; }
        public virtual DbSet<SAFETY_DNGLIST> SAFETY_DNGLIST { get; set; }
        public virtual DbSet<SAFETY_DNGSENDTM> SAFETY_DNGSENDTM { get; set; }
        public virtual DbSet<SAFETY_INFORMATION> SAFETY_INFORMATION { get; set; }
        public virtual DbSet<SAFETY_PATROL_FILES> SAFETY_PATROL_FILES { get; set; }
        public virtual DbSet<SAFETY_PATROL_RECORD> SAFETY_PATROL_RECORD { get; set; }
        public virtual DbSet<SAFETY_SAFECHECK> SAFETY_SAFECHECK { get; set; }
        public virtual DbSet<SAFETY_SCOREMANAGERULE> SAFETY_SCOREMANAGERULE { get; set; }
        public virtual DbSet<SAFETY_SITUATION> SAFETY_SITUATION { get; set; }
        public virtual DbSet<SAFETY_SUPERVISION> SAFETY_SUPERVISION { get; set; }
        public virtual DbSet<SAFETY_VESSEL> SAFETY_VESSEL { get; set; }
        public virtual DbSet<SHIFT_ENGINEERS> SHIFT_ENGINEERS { get; set; }
        public virtual DbSet<SHIFT_PLANE> SHIFT_PLANE { get; set; }
        public virtual DbSet<TransferDataSet> TransferDataSets { get; set; }
        public virtual DbSet<Busy_Vessel_Plan_vw> Busy_Vessel_Plan_vw { get; set; }
        public virtual DbSet<Busy_Vessel_Ship_VW> Busy_Vessel_Ship_VW { get; set; }
        public virtual DbSet<Busy_Working_Type_Vw> Busy_Working_Type_Vw { get; set; }
        public virtual DbSet<COMPANY_PERSON_TRAINING_VW> COMPANY_PERSON_TRAINING_VW { get; set; }
        public virtual DbSet<gjgw_hangcichaxun> gjgw_hangcichaxun { get; set; }
        public virtual DbSet<PERSON_CERTIFICATE_VW> PERSON_CERTIFICATE_VW { get; set; }
        public virtual DbSet<SA_PERSON_INFO_VW> SA_PERSON_INFO_VW { get; set; }
        public virtual DbSet<safety_accident_vw> safety_accident_vw { get; set; }
        public virtual DbSet<safety_breakrule_vw> safety_breakrule_vw { get; set; }
        public virtual DbSet<situationReport_vw> situationReport_vw { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Busy_Information>()
   .Property(e => e.BI_ISREADED)
   .IsFixedLength()
   .IsUnicode(false);

            modelBuilder.Entity<Busy_Information>()
                .Property(e => e.BI_ISMONREADED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Vessel_Ship>()
                .Property(e => e.Bvs_intrace)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Vessel_Ship>()
                .Property(e => e.bvs_note)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Vessel_Ship>()
                .Property(e => e.bvs_voyage)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Vessel_Ship>()
                .Property(e => e.bvs_bthdirc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Vessel_Ship>()
                .Property(e => e.bvs_berthno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Vessel_Ship>()
                .Property(e => e.sln_lne_rtcd)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Working_Type>()
                .Property(e => e.Bvt_CntrIsocd)
                .IsFixedLength();

            modelBuilder.Entity<CERTIFICATE_ORGAN>()
                .Property(e => e.CO_CERTIFICATE)
                .IsUnicode(false);

            modelBuilder.Entity<CERTIFICATE_ORGAN>()
                .Property(e => e.CO_ORGAIN)
                .IsUnicode(false);

            modelBuilder.Entity<CERTIFICATE_ORGAN>()
                .Property(e => e.CO_DEPART)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_HOUR)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_ORAGN)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_TEACHER)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_PLACE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_CONTEN)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_CHECK)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_NODE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_FILES)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_DEP)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .Property(e => e.CT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .HasMany(e => e.PERSON_TRAINING)
                .WithOptional(e => e.COMPANY_TRAINING)
                .HasForeignKey(e => e.PT_CT_ID);

            modelBuilder.Entity<COMPANY_TRAINING>()
                .HasMany(e => e.PERSON_TRAINING1)
                .WithOptional(e => e.COMPANY_TRAINING1)
                .HasForeignKey(e => e.PT_CT_ID);

            modelBuilder.Entity<PERSON_CERTIFICATE>()
                .Property(e => e.PC_CERTIFICATE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE>()
                .Property(e => e.PC_ORGAN)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE>()
                .Property(e => e.PC_PERSON_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE>()
                .Property(e => e.PC_CERTIFICATE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE>()
                .Property(e => e.PC_NODE)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE>()
                .Property(e => e.PC_PERSON_DEPART)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE>()
                .Property(e => e.PC_PERSON_DUTY)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE>()
                .Property(e => e.PC_CERTIFICATE_DEPART)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_TRAINING>()
                .Property(e => e.PT_Node)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_TRAINING>()
                .Property(e => e.PT_OTHERS)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_YPLANID)
                .HasPrecision(9, 0);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_CAMT)
                .HasPrecision(4, 0);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_EMPTID)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_EFFPERIOD)
                .HasPrecision(1, 0);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_SELECTMD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_DMGCFG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_RFCFG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_CSZ_CSIZECD)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_DNGGFG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_CNTRNO)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_CTP_ISOCD)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_OVLMTFG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_HEI_CHEIGHTCD)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_COP_COPERCD)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_VOC_OCRRID)
                .HasPrecision(9, 0);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_STS_CSTATUSID)
                .HasPrecision(9, 0);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_ULP_PORTID)
                .HasPrecision(9, 0);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_TER_TERMCD)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_REGIONCD)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_POT_PORTCD)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_CGROUPFG)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_BILLNO)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_OUTSEQ)
                .HasPrecision(2, 0);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_EMPTY)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .Property(e => e.SPL_SPSTOWFG)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLANS>()
                .HasMany(e => e.PS_STACK_PLAN_AREAS)
                .WithRequired(e => e.PS_STACK_PLANS)
                .HasForeignKey(e => e.SPR_SPL_YPLANID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAFETY_BREAKRULE>()
                .Property(e => e.SB_COMPENSATION_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_BREAKRULE>()
                .Property(e => e.SB_CLAIM_FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_BREAKRULE>()
                .Property(e => e.BS_LVL)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_BREAKRULE>()
                .HasMany(e => e.SAFETY_ACCIDENT)
                .WithOptional(e => e.SAFETY_BREAKRULE)
                .HasForeignKey(e => e.SA_SB_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SAFETY_BREAKRULE>()
                .HasMany(e => e.SAFETY_ACCIDENT_REPORT)
                .WithOptional(e => e.SAFETY_BREAKRULE)
                .HasForeignKey(e => e.SAR_SB_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SAFETY_BREAKRULE>()
                .HasMany(e => e.SAFETY_ACCIDENT_STAFF)
                .WithOptional(e => e.SAFETY_BREAKRULE)
                .HasForeignKey(e => e.SAS_SB_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SAFETY_BREAKRULE>()
                .HasMany(e => e.SAFETY_CLAIM_REPORT)
                .WithOptional(e => e.SAFETY_BREAKRULE)
                .HasForeignKey(e => e.SCR_SB_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SAFETY_BREAKRULE>()
                .HasMany(e => e.SAFETY_COMPENSATION_REPORT)
                .WithOptional(e => e.SAFETY_BREAKRULE)
                .HasForeignKey(e => e.SCPR_SB_ID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SAFETY_NOTICE>()
                .Property(e => e.Contents)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_NOTICE>()
                .Property(e => e.IsDelete)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_NOTICE>()
                .Property(e => e.AddUser)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_NOTICE>()
                .Property(e => e.ModUser)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_SITUATIONTYPE>()
                .HasMany(e => e.SAFETY_SITUATIONDETAIL)
                .WithOptional(e => e.SAFETY_SITUATIONTYPE)
                .HasForeignKey(e => e.SD_ST_ID);

            modelBuilder.Entity<SAFETY_SUPERVISION_JOB>()
                .Property(e => e.SJ_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_SUPERVISION_PROJECT>()
                .Property(e => e.SP_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_MACHINE_WORK>()
                .Property(e => e.MW_MACHINE_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_VESSEL>()
                .Property(e => e.SV_LNE_INTERNALFG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_WORKNOKPI>()
                .Property(e => e.swk_vsl1)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_WORKNOKPI>()
                .Property(e => e.swk_vsl2)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_WORKNOKPI>()
                .Property(e => e.swk_vsl3)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_WORKNOKPI>()
                .Property(e => e.swk_vsl4)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_YARDBUFF>()
                .Property(e => e.SYB_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_YARDBUFF>()
                .Property(e => e.SYB_STBAY)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_YARDBUFF>()
                .Property(e => e.SYB_EDBAY)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_YARDBUFF>()
                .Property(e => e.SYB_ISDELETED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_YARDBUFF>()
                .Property(e => e.SYB_ADDUSR)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_YARDBUFF>()
                .Property(e => e.SYB_DELUSR)
                .IsUnicode(false);

            modelBuilder.Entity<ThroughputReport>()
                .Property(e => e.TR_VesselName)
                .IsUnicode(false);

            modelBuilder.Entity<ThroughputReport>()
                .Property(e => e.TR_VesselVoyage)
                .IsUnicode(false);

            modelBuilder.Entity<ThroughputReport>()
                .Property(e => e.TR_TEU)
                .HasPrecision(18, 1);

            modelBuilder.Entity<ThroughputReport>()
                .Property(e => e.TR_EFFG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThroughputReport>()
                .Property(e => e.TR_SIZE)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_MODEL>()
                .Property(e => e.TM_HOUR)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_MODEL>()
                .Property(e => e.TM_ORAGN)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_MODEL>()
                .Property(e => e.TM_TEACHER)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_MODEL>()
                .Property(e => e.TM_PLACE)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_MODEL>()
                .Property(e => e.TM_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_MODEL>()
                .Property(e => e.TM_CONTEN)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_MODEL>()
                .Property(e => e.TM_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_MODEL>()
                .Property(e => e.TM_CHECK)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_yard_main_new>()
                .Property(e => e.bym_type)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_yard_main_new>()
                .Property(e => e.bym_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLAN_AREAS>()
                .Property(e => e.SPR_SPL_YPLANID)
                .HasPrecision(9, 0);

            modelBuilder.Entity<PS_STACK_PLAN_AREAS>()
                .Property(e => e.SPR_RANGEID)
                .HasPrecision(9, 0);

            modelBuilder.Entity<PS_STACK_PLAN_AREAS>()
                .Property(e => e.SPR_PSTATUS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLAN_AREAS>()
                .Property(e => e.SPR_STACKRULE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLAN_AREAS>()
                .Property(e => e.SPR_STBAY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLAN_AREAS>()
                .Property(e => e.SPR_EDBAY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PS_STACK_PLAN_AREAS>()
                .Property(e => e.SPR_GROUPNO)
                .HasPrecision(2, 0);

            modelBuilder.Entity<ps_vessel_occurences>()
                .Property(e => e.voc_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<SAFETY_ACCIDENT_REPORT>()
                .Property(e => e.SAR_ISFINISH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_ACCIDENT_STAFF>()
                .Property(e => e.SAS_NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.ylocation)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.cntrno)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.cszie)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.cheight)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.ctype)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.ccopre)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.cstatus)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.vname)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.voyage)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.viefg)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.dngtype)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.dngno)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.pname)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.solution)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.attention)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.mduser1)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.mduser2)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGLIST>()
                .Property(e => e.agent)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_DNGSENDTM>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_PATROL_FILES>()
                .Property(e => e.SPF_FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_PATROL_FILES>()
                .Property(e => e.SPF_IMPORT_USER)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_PATROL_RECORD>()
                .Property(e => e.SPR_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_PATROL_RECORD>()
                .Property(e => e.SPR_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_PATROL_RECORD>()
                .Property(e => e.SPR_LINE)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_SAFECHECK>()
                .Property(e => e.SC_PICT1)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_SAFECHECK>()
                .Property(e => e.SC_PICT2)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_SAFECHECK>()
                .Property(e => e.SC_PICT3)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_SCOREMANAGERULE>()
                .Property(e => e.SMR_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_PORT)
                .IsFixedLength();

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_ROPEBINDTM)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_LADERDOWNTM)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_INSPECARRITM)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_INSPECUPTM)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_INSPECDOWNTM)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_WORKERUPTM)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_WORKERDOWN)
                .IsUnicode(false);

            modelBuilder.Entity<SAFETY_VESSEL>()
                .Property(e => e.SV_NEXTPORT)
                .IsFixedLength();

            modelBuilder.Entity<SHIFT_PLANE>()
                .Property(e => e.SP_SHIFT)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT_PLANE>()
                .Property(e => e.SP_SHIFT_USER)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_VNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_VOYAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_CSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_E20)
                .HasPrecision(18, 1);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_E40)
                .HasPrecision(18, 1);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_E45)
                .HasPrecision(18, 1);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_F20)
                .HasPrecision(18, 1);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_F40)
                .HasPrecision(18, 1);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_F45)
                .HasPrecision(18, 1);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<TransferDataSet>()
                .Property(e => e.TF_NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Vessel_Plan_vw>()
                .Property(e => e.班组日期)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Vessel_Ship_VW>()
                .Property(e => e.内贸标志)
                .IsUnicode(false);

            modelBuilder.Entity<Busy_Working_Type_Vw>()
                .Property(e => e.工班日期)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.PT_Node)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.CT_HOUR)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.CT_ORAGN)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.CT_TEACHER)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.CT_PLACE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.CT_POINT)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.CT_CONTEN)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.CT_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.CT_CHECK)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY_PERSON_TRAINING_VW>()
                .Property(e => e.USR_IS_LEAVE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.TERCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VLS_ENGNM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VOC_OCRRID)
                .HasPrecision(9, 0);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.AGENTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.LIHUO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.IEFG)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VOYAGE)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.IEID)
                .HasPrecision(9, 0);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VSLCODE)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VSLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.LNECODE)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.LENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.LNETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.NEIWAIMAO)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.Expr2)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.驳船否)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.iz)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.t)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.pp)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.np)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VBT_ABERTHNO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VBT_PBTHTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VOC_ARRIVETM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VBT_PBTHTMMM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VBT_ABTHTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VIE_AWKSTTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VIE_AWKENTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VBT_PDPTTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VBT_ADPTTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VBT_PDPTTMM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VOC_DPORTTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VBT_ADPTTMMM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VOC_RCVSTTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VOC_RCVEDTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VOC_TEREEDTM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.VOC_RCVEDTMM)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.抵港吃水)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.离港吃水)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.是否使用拖轮)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.引航标志)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.倒箱计划作业数量)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.长杆计划作业箱数)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.长杆起始贝位)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.长杆结束贝位)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.长杆实际作业箱数)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.作业舱盖板数量)
                .HasPrecision(3, 0);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.作业工具箱数量)
                .HasPrecision(3, 0);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注1)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注2)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注3)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注4)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注5)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注6)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注7)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注8)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注9)
                .IsUnicode(false);

            modelBuilder.Entity<gjgw_hangcichaxun>()
                .Property(e => e.备注10)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE_VW>()
                .Property(e => e.PC_PERSON_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE_VW>()
                .Property(e => e.PC_CERTIFICATE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE_VW>()
                .Property(e => e.PC_CERTIFICATE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE_VW>()
                .Property(e => e.PC_ORGAN)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE_VW>()
                .Property(e => e.PC_NODE)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON_CERTIFICATE_VW>()
                .Property(e => e.PC_CERTIFICATE_DEPART)
                .IsUnicode(false);

            modelBuilder.Entity<SA_PERSON_INFO_VW>()
                .Property(e => e.USR_IS_LEAVE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<safety_accident_vw>()
                .Property(e => e.日期)
                .IsUnicode(false);

            modelBuilder.Entity<safety_accident_vw>()
                .Property(e => e.记录时间)
                .IsUnicode(false);

            modelBuilder.Entity<safety_breakrule_vw>()
                .Property(e => e.日期)
                .IsUnicode(false);

            modelBuilder.Entity<safety_breakrule_vw>()
                .Property(e => e.记录时间)
                .IsUnicode(false);

            modelBuilder.Entity<safety_breakrule_vw>()
                .Property(e => e.严重程度)
                .IsUnicode(false);

            modelBuilder.Entity<situationReport_vw>()
                .Property(e => e.工班)
                .IsUnicode(false);
        }
    }
}
