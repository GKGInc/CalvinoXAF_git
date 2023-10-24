using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CalvinoXAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[NavigationItem("Enterprise")]
    public class PersonalInjury : CustomBaseObject
    { 
        public PersonalInjury(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[personal_key] [int] NOT NULL,
        //[client_key] [int] NOT NULL,
        //[pre_atty] [char](3) NOT NULL,
        //[lit_atty] [char](3) NOT NULL,
        //[co_atty] [char](3) NOT NULL,
        //[intake_d] [datetime] NOT NULL,
        //[ref_by] [char](35) NOT NULL,
        //[stat_lim_d] [datetime] NOT NULL,
        //[marital_s] [char](1) NOT NULL,
        //[mar_date] [datetime] NOT NULL,
        //[injury_d] [datetime] NOT NULL,
        //[inc_time] [char](10) NOT NULL,
        //[inc_place] [text] NOT NULL,
        //[pol_dept] [char](40) NOT NULL,
        //[witness] [text] NOT NULL,
        //[reg_recv] [char](1) NOT NULL,
        //[polrep_recv] [char](1) NOT NULL,
        //[comm_id] [int] NOT NULL,
        //[case_close] [datetime] NOT NULL,
        //[clos_file_no] [char](12) NOT NULL,
        //[lic_no] [char](15) NOT NULL,
        //[lic_type] [char](10) NOT NULL,
        //[lic_state] [char](2) NOT NULL,
        //[filler] [char](5) NOT NULL,
        //[desc_inc] [text] NOT NULL,
        //[sp_name] [char](35) NOT NULL,
        //[t_diagno] [text] NOT NULL,
        //[matter] [char](8) NOT NULL,
        //[state] [char](2) NOT NULL,
        //[fileunder] [char](45) NOT NULL,
        //[case_type] [char](15) NOT NULL,
        //[med24] [char](3) NOT NULL,
        //[medspec] [text] NOT NULL,
        //[suspend] [text] NOT NULL,
        //[citation] [text] NOT NULL,
        //[comgo] [text] NOT NULL,
        //[long_desc] [char](40) NOT NULL,
        //[insuit] [char](3) NOT NULL,
        //[dte_insuit] [datetime] NOT NULL,
        //[main_key] [int] NOT NULL,
        //[timestamp_column] [timestamp] NOT NULL,

        //[comm_id] [int] NOT NULL,
        //[comments] [text] NOT NULL,
        //[filler] [bit] NOT NULL,
        //[timestamp_column] [timestamp] NOT NULL,

        private int _PersonalKey;
        public int PersonalKey
        {
            get { return _PersonalKey; }
            set { SetPropertyValue<int>(nameof(PersonalKey), ref _PersonalKey, value); }
        }

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }

        private string _PreAtty;
        [Size(3)]
        public string PreAtty
        {
            get { return _PreAtty; }
            set { SetPropertyValue<string>(nameof(PreAtty), ref _PreAtty, value); }
        }

        private string _LitAtty;
        [Size(3)]
        public string LitAtty
        {
            get { return _LitAtty; }
            set { SetPropertyValue<string>(nameof(LitAtty), ref _LitAtty, value); }
        }

        private string _CoAtty;
        [Size(3)]
        public string CoAtty
        {
            get { return _CoAtty; }
            set { SetPropertyValue<string>(nameof(CoAtty), ref _CoAtty, value); }
        }

        public DateTime _IntakeDate;
        public DateTime IntakeDate
        {
            get { return _IntakeDate; }
            set { SetPropertyValue<DateTime>(nameof(IntakeDate), ref _IntakeDate, value); }
        }

        private string _RefBy;
        [Size(45)]
        public string RefBy
        {
            get { return _RefBy; }
            set { SetPropertyValue<string>(nameof(RefBy), ref _RefBy, value); }
        }

        public DateTime _StatuteOfLimitations;
        public DateTime StatuteOfLimitations
        {
            get { return _StatuteOfLimitations; }
            set { SetPropertyValue<DateTime>(nameof(StatuteOfLimitations), ref _StatuteOfLimitations, value); }
        }

        private string _MaritalStatus;
        [Size(1)]
        public string MaritalStatus
        {
            get { return _MaritalStatus; }
            set { SetPropertyValue<string>(nameof(MaritalStatus), ref _MaritalStatus, value); }
        }

        public DateTime _MaritalDate;
        public DateTime MaritalDate
        {
            get { return _MaritalDate; }
            set { SetPropertyValue<DateTime>(nameof(MaritalDate), ref _MaritalDate, value); }
        }

        public DateTime _InjuryDate;
        public DateTime InjuryDate
        {
            get { return _InjuryDate; }
            set { SetPropertyValue<DateTime>(nameof(InjuryDate), ref _InjuryDate, value); }
        }

        private string _IncidentTime;
        [Size(30)]
        public string IncidentTime
        {
            get { return _IncidentTime; }
            set { SetPropertyValue<string>(nameof(IncidentTime), ref _IncidentTime, value); }
        }

        private string _IncidentPlace;
        [Size(SizeAttribute.Unlimited)]
        public string IncidentPlace
        {
            get { return _IncidentPlace; }
            set { SetPropertyValue<string>(nameof(IncidentPlace), ref _IncidentPlace, value); }
        }

        private string _PoliceDepartment;
        [Size(60)]
        public string PoliceDepartment
        {
            get { return _PoliceDepartment; }
            set { SetPropertyValue<string>(nameof(PoliceDepartment), ref _PoliceDepartment, value); }
        }

        private string _Witness;
        [Size(SizeAttribute.Unlimited)]
        public string Witness
        {
            get { return _Witness; }
            set { SetPropertyValue<string>(nameof(Witness), ref _Witness, value); }
        }

        private string _RegRecv;
        [Size(1)]
        public string RegRecv
        {
            get { return _RegRecv; }
            set { SetPropertyValue<string>(nameof(RegRecv), ref _RegRecv, value); }
        }

        private string _PoliceReportReceived;
        [Size(1)]
        public string PoliceReportReceived
        {
            get { return _PoliceReportReceived; }
            set { SetPropertyValue<string>(nameof(PoliceReportReceived), ref _PoliceReportReceived, value); }
        }

        private int _CommId;
        public int CommId
        {
            get { return _CommId; }
            set { SetPropertyValue<int>(nameof(CommId), ref _CommId, value); }
        }

        public DateTime _CaseClosed;
        public DateTime CaseClosed
        {
            get { return _CaseClosed; }
            set { SetPropertyValue<DateTime>(nameof(CaseClosed), ref _CaseClosed, value); }
        }

        private string _CloseFileNo;
        [Size(12)]
        public string CloseFileNo
        {
            get { return _CloseFileNo; }
            set { SetPropertyValue<string>(nameof(CloseFileNo), ref _CloseFileNo, value); }
        }

        private string _LicenseNo;
        [Size(15)]
        public string LicenseNo
        {
            get { return _LicenseNo; }
            set { SetPropertyValue<string>(nameof(LicenseNo), ref _LicenseNo, value); }
        }

        private string _LicenseType;
        [Size(10)]
        public string LicenseType
        {
            get { return _LicenseType; }
            set { SetPropertyValue<string>(nameof(LicenseType), ref _LicenseType, value); }
        }

        private string _LicenseState;
        [Size(10)]
        public string LicenseState
        {
            get { return _LicenseState; }
            set { SetPropertyValue<string>(nameof(LicenseState), ref _LicenseState, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        private string _desc_inc;
        [Size(SizeAttribute.Unlimited)]
        public string desc_inc
        {
            get { return _desc_inc; }
            set { SetPropertyValue<string>(nameof(desc_inc), ref _desc_inc, value); }
        }
        private string _sp_name;
        [Size(40)]
        public string sp_name
        {
            get { return _sp_name; }
            set { SetPropertyValue<string>(nameof(sp_name), ref _sp_name, value); }
        }

        private string _t_diagno;
        [Size(SizeAttribute.Unlimited)]
        public string t_diagno
        {
            get { return _t_diagno; }
            set { SetPropertyValue<string>(nameof(t_diagno), ref _t_diagno, value); }
        }

        private string _Matter;
        [Size(8)]
        public string Matter
        {
            get { return _Matter; }
            set { SetPropertyValue<string>(nameof(Matter), ref _Matter, value); }
        }

        private string _State;
        [Size(2)]
        public string State
        {
            get { return _State; }
            set { SetPropertyValue<string>(nameof(State), ref _State, value); }
        }

        private string _FileUnder;
        [Size(45)]
        public string FileUnder
        {
            get { return _FileUnder; }
            set { SetPropertyValue<string>(nameof(FileUnder), ref _FileUnder, value); }
        }

        private string _CaseType;
        [Size(15)]
        public string CaseType
        {
            get { return _CaseType; }
            set { SetPropertyValue<string>(nameof(CaseType), ref _CaseType, value); }
        }

        private string _Med24;
        [Size(3)]
        public string Med24
        {
            get { return _Med24; }
            set { SetPropertyValue<string>(nameof(Med24), ref _Med24, value); }
        }

        private string _MedSpec;
        [Size(SizeAttribute.Unlimited)]
        public string MedSpec
        {
            get { return _MedSpec; }
            set { SetPropertyValue<string>(nameof(MedSpec), ref _MedSpec, value); }
        }

        private string _Suspend;
        [Size(SizeAttribute.Unlimited)]
        public string Suspend
        {
            get { return _Suspend; }
            set { SetPropertyValue<string>(nameof(Suspend), ref _Suspend, value); }
        }

        private string _Citation;
        [Size(SizeAttribute.Unlimited)]
        public string Citation
        {
            get { return _Citation; }
            set { SetPropertyValue<string>(nameof(Citation), ref _Citation, value); }
        }

        private string _Comgo;
        [Size(SizeAttribute.Unlimited)]
        public string Comgo
        {
            get { return _Comgo; }
            set { SetPropertyValue<string>(nameof(Comgo), ref _Comgo, value); }
        }

        private string _LongDesc;
        [Size(100)]
        public string LongDesc
        {
            get { return _LongDesc; }
            set { SetPropertyValue<string>(nameof(LongDesc), ref _LongDesc, value); }
        }

        private string _Insuit;
        [Size(3)]
        public string Insuit
        {
            get { return _Insuit; }
            set { SetPropertyValue<string>(nameof(Insuit), ref _Insuit, value); }
        }

        public DateTime _DateInsuit;
        public DateTime DateInsuit
        {
            get { return _DateInsuit; }
            set { SetPropertyValue<DateTime>(nameof(DateInsuit), ref _DateInsuit, value); }
        }

        private int _MainKey;
        public int MainKey
        {
            get { return _MainKey; }
            set { SetPropertyValue<int>(nameof(MainKey), ref _MainKey, value); }
        }

        private string _Comments;
        [Size(SizeAttribute.Unlimited)]
        public string Comments
        {
            get { return _Comments; }
            set { SetPropertyValue<string>(nameof(Comments), ref _Comments, value); }
        }

        public DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }
    }
}