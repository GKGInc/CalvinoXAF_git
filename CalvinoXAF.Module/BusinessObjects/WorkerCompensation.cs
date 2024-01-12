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
    public class WorkerCompensation : CustomBaseObject
    { 
        public WorkerCompensation(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[client_key] [int] NOT NULL,
        //[workcomp_key] [int] NOT NULL,
        //[atty] [char](3) NOT NULL,
        //[intake_d] [datetime] NOT NULL,
        //[ref_by] [char](35) NOT NULL,
        //[injury_d] [datetime] NOT NULL,
        //[ic_d] [datetime] NOT NULL,
        //[marital_s] [char](1) NOT NULL,
        //[sp_wrk] [char](1) NOT NULL,
        //[intrp] [char](1) NOT NULL,
        //[appt_d] [datetime] NOT NULL,
        //[stat_lim_d] [datetime] NOT NULL,
        //[stat_flash_d] [datetime] NOT NULL,
        //[pet_com_d] [datetime] NOT NULL,
        //[emp_name] [char](35) NOT NULL,
        //[emp_addr1] [char](35) NOT NULL,
        //[emp_addr2] [char](35) NOT NULL,
        //[emp_city] [char](15) NOT NULL,
        //[emp_state] [char](2) NOT NULL,
        //[emp_zip] [char](10) NOT NULL,
        //[emp_phone] [char](17) NOT NULL,
        //[time_empl] [char](20) NOT NULL,
        //[noti_empl] [char](20) NOT NULL,
        //[noti_whom] [char](20) NOT NULL,
        //[insur_key] [int] NOT NULL,
        //[emplye_title] [char](60) NOT NULL,
        //[duties] [text] NOT NULL,
        //[aww] [numeric](9, 2) NOT NULL,
        //[comp_rate] [numeric](9, 2) NOT NULL,
        //[comp_yr] [numeric](9, 2) NOT NULL,
        //[rtn_work] [char](1) NOT NULL,
        //[name_co] [char](35) NOT NULL,
        //[tdi_yn] [char](1) NOT NULL,
        //[tdi_rcvd] [char](60) NOT NULL,
        //[unemp_yn] [char](1) NOT NULL,
        //[unemp_rcvd] [char](60) NOT NULL,
        //[welf_yn] [char](1) NOT NULL,
        //[welf_rcvd] [char](60) NOT NULL,
        //[tpc_rcvd] [char](60) NOT NULL,
        //[suplwage] [char](60) NOT NULL,
        //[t_diagno] [text] NOT NULL,
        //[moa_file] [datetime] NOT NULL,
        //[moa_ninj] [text] NOT NULL,
        //[case_close] [datetime] NOT NULL,
        //[clos_file_no] [char](12) NOT NULL,
        //[matter] [char](8) NOT NULL,
        //[worknote_id] [int] NOT NULL,
        //[filler] [bit] NOT NULL,
        //[timestamp_column] [timestamp] NOT NULL,

	//[worknote_id] [int] NOT NULL,
	//[comments] [text] NOT NULL,
	//[filler] [bit] NOT NULL,
	//[timestamp_column] [timestamp] NOT NULL,

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }

        private int _WorkerCompensationKey;
        public int WorkerCompensationKey
        {
            get { return _WorkerCompensationKey; }
            set { SetPropertyValue<int>(nameof(WorkerCompensationKey), ref _WorkerCompensationKey, value); }
        }

        private string _Atty;
        [Size(3)]
        public string Atty
        {
            get { return _Atty; }
            set { SetPropertyValue<string>(nameof(Atty), ref _Atty, value); }
        }

        private DateTime _IntakeDate;
        public DateTime IntakeDate
        {
            get { return _IntakeDate; }
            set { SetPropertyValue<DateTime>(nameof(IntakeDate), ref _IntakeDate, value); }
        }

        private string _RefBy;
        [Size(30)]
        public string RefBy
        {
            get { return _RefBy; }
            set { SetPropertyValue<string>(nameof(RefBy), ref _RefBy, value); }
        }

        private DateTime _InjuryDate;
        public DateTime InjuryDate
        {
            get { return _InjuryDate; }
            set { SetPropertyValue<DateTime>(nameof(InjuryDate), ref _InjuryDate, value); }
        }

        private DateTime _ic_d;
        public DateTime ic_d
        {
            get { return _ic_d; }
            set { SetPropertyValue<DateTime>(nameof(ic_d), ref _ic_d, value); }
        }

        private string _MaritalStatus;
        [Size(1)]
        public string MaritalStatus
        {
            get { return _MaritalStatus; }
            set { SetPropertyValue<string>(nameof(MaritalStatus), ref _MaritalStatus, value); }
        }

        private string _SpWork;
        [Size(1)]
        public string SpWork
        {
            get { return _SpWork; }
            set { SetPropertyValue<string>(nameof(SpWork), ref _SpWork, value); }
        }

        private string _Intrp;
        [Size(1)]
        public string Intrp
        {
            get { return _Intrp; }
            set { SetPropertyValue<string>(nameof(Intrp), ref _Intrp, value); }
        }

        private DateTime _AppointmentDate;
        public DateTime AppointmentDate
        {
            get { return _AppointmentDate; }
            set { SetPropertyValue<DateTime>(nameof(AppointmentDate), ref _AppointmentDate, value); }
        }

        private DateTime _StatuteOfLimitations;
        public DateTime StatuteOfLimitations
        {
            get { return _StatuteOfLimitations; }
            set { SetPropertyValue<DateTime>(nameof(StatuteOfLimitations), ref _StatuteOfLimitations, value); }
        }

        private DateTime _stat_flash_d;
        public DateTime stat_flash_d
        {
            get { return _stat_flash_d; }
            set { SetPropertyValue<DateTime>(nameof(stat_flash_d), ref _stat_flash_d, value); }
        }

        private DateTime _pet_com_d;
        public DateTime pet_com_d
        {
            get { return _pet_com_d; }
            set { SetPropertyValue<DateTime>(nameof(pet_com_d), ref _pet_com_d, value); }
        }

        private string _EmployeeName;
        [Size(45)]
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { SetPropertyValue<string>(nameof(EmployeeName), ref _EmployeeName, value); }
        }

        private string _EmployeeAddress1;
        [Size(35)]
        public string EmployeeAddress1
        {
            get { return _EmployeeAddress1; }
            set { SetPropertyValue<string>(nameof(EmployeeAddress1), ref _EmployeeAddress1, value); }
        }

        private string _EmployeeAddress2;
        [Size(35)]
        public string EmployeeAddress2
        {
            get { return _EmployeeAddress2; }
            set { SetPropertyValue<string>(nameof(EmployeeAddress2), ref _EmployeeAddress2, value); }
        }

        private string _EmployeeCity;
        [Size(18)]
        public string EmployeeCity
        {
            get { return _EmployeeCity; }
            set { SetPropertyValue<string>(nameof(EmployeeCity), ref _EmployeeCity, value); }
        }

        private string _EmployeeState;
        [Size(2)]
        public string EmployeeState
        {
            get { return _EmployeeState; }
            set { SetPropertyValue<string>(nameof(EmployeeState), ref _EmployeeState, value); }
        }

        private string _EmployeeZipCode;
        [Size(10)]
        public string EmployeeZipCode
        {
            get { return _EmployeeZipCode; }
            set { SetPropertyValue<string>(nameof(EmployeeZipCode), ref _EmployeeZipCode, value); }
        }

        private string _EmployeePhone;
        [Size(35)]
        public string EmployeePhone
        {
            get { return _EmployeePhone; }
            set { SetPropertyValue<string>(nameof(EmployeePhone), ref _EmployeePhone, value); }
        }

        private string _time_empl;
        [Size(20)]
        public string time_empl
        {
            get { return _time_empl; }
            set { SetPropertyValue<string>(nameof(time_empl), ref _time_empl, value); }
        }

        private string _noti_empl;
        [Size(20)]
        public string noti_empl
        {
            get { return _noti_empl; }
            set { SetPropertyValue<string>(nameof(noti_empl), ref _noti_empl, value); }
        }

        private string _noti_whom;
        [Size(60)]
        public string noti_whom
        {
            get { return _noti_whom; }
            set { SetPropertyValue<string>(nameof(noti_whom), ref _noti_whom, value); }
        }

        private int _InsuranceKey;
        public int InsuranceKey
        {
            get { return _InsuranceKey; }
            set { SetPropertyValue<int>(nameof(InsuranceKey), ref _InsuranceKey, value); }
        }

        private string _Duties;
        [Size(SizeAttribute.Unlimited)]
        public string Duties
        {
            get { return _Duties; }
            set { SetPropertyValue<string>(nameof(Duties), ref _Duties, value); }
        }

        private string _EmployeeTitle;
        [Size(35)]
        public string EmployeeTitle
        {
            get { return _EmployeeTitle; }
            set { SetPropertyValue<string>(nameof(EmployeeTitle), ref _EmployeeTitle, value); }
        }

        private decimal _aww;
        public decimal aww
        {
            get { return _aww; }
            set { SetPropertyValue<decimal>(nameof(aww), ref _aww, value); }
        }

        private decimal _CompanyRate;
        public decimal CompanyRate
        {
            get { return _CompanyRate; }
            set { SetPropertyValue<decimal>(nameof(CompanyRate), ref _CompanyRate, value); }
        }

        private decimal _CompanyYear;
        public decimal CompanyYear
        {
            get { return _CompanyYear; }
            set { SetPropertyValue<decimal>(nameof(CompanyYear), ref _CompanyYear, value); }
        }

        private string _RtnWork;
        [Size(1)]
        public string RtnWork
        {
            get { return _RtnWork; }
            set { SetPropertyValue<string>(nameof(RtnWork), ref _RtnWork, value); }
        }

        private string _NameCompany;
        [Size(35)]
        public string NameCompany
        {
            get { return _NameCompany; }
            set { SetPropertyValue<string>(nameof(NameCompany), ref _NameCompany, value); }
        }

        private string _tdi_yn;
        [Size(1)]
        public string tdi_yn
        {
            get { return _tdi_yn; }
            set { SetPropertyValue<string>(nameof(tdi_yn), ref _tdi_yn, value); }
        }

        private string _tdi_rcvd;
        [Size(60)]
        public string tdi_rcvd
        {
            get { return _tdi_rcvd; }
            set { SetPropertyValue<string>(nameof(tdi_rcvd), ref _tdi_rcvd, value); }
        }

        private string _unemp_yn;
        [Size(1)]
        public string unemp_yn
        {
            get { return _unemp_yn; }
            set { SetPropertyValue<string>(nameof(unemp_yn), ref _unemp_yn, value); }
        }

        private string _UnemploymentReceived;
        [Size(60)]
        public string UnemploymentReceived
        {
            get { return _UnemploymentReceived; }
            set { SetPropertyValue<string>(nameof(UnemploymentReceived), ref _UnemploymentReceived, value); }
        }

        private string _welf_yn;
        [Size(1)]
        public string welf_yn
        {
            get { return _welf_yn; }
            set { SetPropertyValue<string>(nameof(welf_yn), ref _welf_yn, value); }
        }

        private string _welf_rcvd;
        [Size(60)]
        public string welf_rcvd
        {
            get { return _welf_rcvd; }
            set { SetPropertyValue<string>(nameof(welf_rcvd), ref _welf_rcvd, value); }
        }

        private string _tpc_rcvd;
        [Size(60)]
        public string tpc_rcvd
        {
            get { return _tpc_rcvd; }
            set { SetPropertyValue<string>(nameof(tpc_rcvd), ref _tpc_rcvd, value); }
        }

        private string _suplwage;
        [Size(60)]
        public string suplwage
        {
            get { return _suplwage; }
            set { SetPropertyValue<string>(nameof(suplwage), ref _suplwage, value); }
        }

        private string _t_diagno;
        [Size(SizeAttribute.Unlimited)]
        public string t_diagno
        {
            get { return _t_diagno; }
            set { SetPropertyValue<string>(nameof(t_diagno), ref _t_diagno, value); }
        }

        private DateTime _moa_file;
        public DateTime moa_file
        {
            get { return _moa_file; }
            set { SetPropertyValue<DateTime>(nameof(moa_file), ref _moa_file, value); }
        }

        private string _moa_ninj;
        [Size(SizeAttribute.Unlimited)]
        public string moa_ninj
        {
            get { return _moa_ninj; }
            set { SetPropertyValue<string>(nameof(moa_ninj), ref _moa_ninj, value); }
        }

        private DateTime _CaseClosed;
        public DateTime CaseClosed
        {
            get { return _CaseClosed; }
            set { SetPropertyValue<DateTime>(nameof(CaseClosed), ref _CaseClosed, value); }
        }

        private string _ClosedFileNo;
        [Size(12)]
        public string ClosedFileNo
        {
            get { return _ClosedFileNo; }
            set { SetPropertyValue<string>(nameof(ClosedFileNo), ref _ClosedFileNo, value); }
        }

        private string _Matter;
        [Size(8)]
        public string Matter
        {
            get { return _Matter; }
            set { SetPropertyValue<string>(nameof(Matter), ref _Matter, value); }
        }

        private int _WorknoteId;
        public int WorknoteId
        {
            get { return _WorknoteId; }
            set { SetPropertyValue<int>(nameof(WorknoteId), ref _WorknoteId, value); }
        }

        private string _Comments;
        [Size(SizeAttribute.Unlimited)]
        public string Comments
        {
            get { return _Comments; }
            set { SetPropertyValue<string>(nameof(Comments), ref _Comments, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        private DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }

    }
}