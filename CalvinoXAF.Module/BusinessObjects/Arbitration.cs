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
    public class Arbitration : CustomBaseObject
    { 
        public Arbitration(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[arbitr_key] [int] NOT NULL,
        //[client_key] [int] NOT NULL,
        //[ref_by] [char](20) NOT NULL,
        //[intake_dat] [datetime] NOT NULL,
        //[doi] [datetime] NOT NULL,
        //[arb_atty1] [char](3) NOT NULL,
        //[arb_atty2] [char](3) NOT NULL,
        //[long_desc] [char](40) NOT NULL,
        //[case_no] [char](15) NOT NULL,
        //[closedate] [datetime] NOT NULL,
        //[close_no] [char](8) NOT NULL,
        //[filler] [bit] NOT NULL,
        //[comments] [text] NOT NULL,
        //[matter] [char](8) NOT NULL,
        //[evaluation] [text] NOT NULL,
        //[date_sched] [datetime] NOT NULL,
        //[timestamp_column] [timestamp] NOT NULL,

        private int _ArbitrationKey;
        public int ArbitrationKey
        {
            get { return _ArbitrationKey; }
            set { SetPropertyValue<int>(nameof(ArbitrationKey), ref _ArbitrationKey, value); }
        }

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }

        private string _ReferenceBy;
        [Size(20)]
        public string ReferenceBy
        {
            get { return _ReferenceBy; }
            set { SetPropertyValue<string>(nameof(ReferenceBy), ref _ReferenceBy, value); }
        }

        private DateTime _IntakeDate;
        public DateTime IntakeDate
        {
            get { return _IntakeDate; }
            set { SetPropertyValue<DateTime>(nameof(IntakeDate), ref _IntakeDate, value); }
        }

        private DateTime _DOI;
        public DateTime DOI
        {
            get { return _DOI; }
            set { SetPropertyValue<DateTime>(nameof(DOI), ref _DOI, value); }
        }

        private string _ArbitrationAtty1;
        [Size(3)]
        public string ArbitrationAtty1
        {
            get { return _ArbitrationAtty1; }
            set { SetPropertyValue<string>(nameof(ArbitrationAtty1), ref _ArbitrationAtty1, value); }
        }

        private string _ArbitrationAtty2;
        [Size(3)]
        public string ArbitrationAtty2
        {
            get { return _ArbitrationAtty2; }
            set { SetPropertyValue<string>(nameof(ArbitrationAtty2), ref _ArbitrationAtty2, value); }
        }

        private string _LongDescription;
        public string LongDescription
        {
            get { return _LongDescription; }
            set { SetPropertyValue<string>(nameof(LongDescription), ref _LongDescription, value); }
        }

        private string _CaseNo;
        [Size(15)]
        public string CaseNo
        {
            get { return _CaseNo; }
            set { SetPropertyValue<string>(nameof(CaseNo), ref _CaseNo, value); }
        }

        private DateTime _ClosedDate;
        public DateTime ClosedDate
        {
            get { return _ClosedDate; }
            set { SetPropertyValue<DateTime>(nameof(ClosedDate), ref _ClosedDate, value); }
        }

        private string _CloseNo;
        [Size(8)]
        public string CloseNo
        {
            get { return _CloseNo; }
            set { SetPropertyValue<string>(nameof(CloseNo), ref _CloseNo, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        private string _Comments;
        public string Comments
        {
            get { return _Comments; }
            set { SetPropertyValue<string>(nameof(Comments), ref _Comments, value); }
        }

        private string _Matter;
        [Size(8)]
        public string Matter
        {
            get { return _Matter; }
            set { SetPropertyValue<string>(nameof(Matter), ref _Matter, value); }
        }

        private string _Evaluation;
        [Size(SizeAttribute.Unlimited)]
        public string Evaluation
        {
            get { return _Evaluation; }
            set { SetPropertyValue<string>(nameof(Evaluation), ref _Evaluation, value); }
        }

        private DateTime _DateScheduled;
        public DateTime DateScheduled
        {
            get { return _DateScheduled; }
            set { SetPropertyValue<DateTime>(nameof(DateScheduled), ref _DateScheduled, value); }
        }

        private DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }


    }
}