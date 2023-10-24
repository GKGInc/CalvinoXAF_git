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
    public class GeneralInformation : CustomBaseObject
    { 
        public GeneralInformation(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

	    //[other_key] [int] NOT NULL,
	    //[client_key] [int] NOT NULL,
	    //[ref_by] [char](20) NOT NULL,
	    //[intake_dat] [datetime] NOT NULL,
	    //[doi] [datetime] NOT NULL,
	    //[pre_atty] [char](3) NOT NULL,
	    //[lit_atty] [char](3) NOT NULL,
	    //[case_type] [char](15) NOT NULL,
	    //[closedate] [datetime] NOT NULL,
	    //[close_no] [char](14) NOT NULL,
	    //[matter] [char](8) NOT NULL,
	    //[filler] [bit] NOT NULL,
	    //[comments] [text] NOT NULL,
	    //[long_desc] [text] NOT NULL,
	    //[timestamp_column] [timestamp] NOT NULL,

        private int _OtherKey;
        public int OtherKey
        {
            get { return _OtherKey; }
            set { SetPropertyValue<int>(nameof(OtherKey), ref _OtherKey, value); }
        }

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }

        private string _RefBy;
        [Size(20)]
        public string RefBy
        {
            get { return _RefBy; }
            set { SetPropertyValue<string>(nameof(RefBy), ref _RefBy, value); }
        }

        public DateTime _IntakeDate;
        public DateTime IntakeDate
        {
            get { return _IntakeDate; }
            set { SetPropertyValue<DateTime>(nameof(IntakeDate), ref _IntakeDate, value); }
        }

        public DateTime _DOI;
        public DateTime DOI
        {
            get { return _DOI; }
            set { SetPropertyValue<DateTime>(nameof(DOI), ref _DOI, value); }
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

        private string _CaseType;
        [Size(15)]
        public string CaseType
        {
            get { return _CaseType; }
            set { SetPropertyValue<string>(nameof(CaseType), ref _CaseType, value); }
        }

        public DateTime _CloseDate;
        public DateTime CloseDate
        {
            get { return _CloseDate; }
            set { SetPropertyValue<DateTime>(nameof(CloseDate), ref _CloseDate, value); }
        }

        private string _CloseNo;
        [Size(14)]
        public string CloseNo
        {
            get { return _CloseNo; }
            set { SetPropertyValue<string>(nameof(CloseNo), ref _CloseNo, value); }
        }

        private string _Matter;
        [Size(8)]
        public string Matter
        {
            get { return _Matter; }
            set { SetPropertyValue<string>(nameof(Matter), ref _Matter, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        private string _Comments;
        [Size(SizeAttribute.Unlimited)]
        public string Comments
        {
            get { return _Comments; }
            set { SetPropertyValue<string>(nameof(Comments), ref _Comments, value); }
        }

        private string _LongDescription;
        [Size(SizeAttribute.Unlimited)]
        public string LongDescription
        {
            get { return _LongDescription; }
            set { SetPropertyValue<string>(nameof(LongDescription), ref _LongDescription, value); }
        }

        public DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }


    }
}