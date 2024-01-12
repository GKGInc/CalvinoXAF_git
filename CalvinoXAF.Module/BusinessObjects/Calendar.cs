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
    public class Calendar : CustomBaseObject
    { 
        public Calendar(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

	    //[calendar_key] [int] NOT NULL,
	    //[ssn] [char](9) NOT NULL,
	    //[date] [datetime] NOT NULL,
	    //[who] [char](10) NOT NULL,
	    //[notes] [text] NOT NULL,
	    //[client_key] [int] NOT NULL,
	    //[appl_key] [int] NOT NULL,
	    //[appl_id] [char](1) NOT NULL,
	    //[discard] [bit] NOT NULL,
	    //[action] [char](1) NOT NULL,
	    //[timestamp_column] [timestamp] NOT NULL,

        private int _CalendarKey;
        public int CalendarKey
        {
            get { return _CalendarKey; }
            set { SetPropertyValue<int>(nameof(CalendarKey), ref _CalendarKey, value); }
        }

        private string _SSN;
        [Size(9)]
        public string SSN
        {
            get { return _SSN; }
            set { SetPropertyValue<string>(nameof(SSN), ref _SSN, value); }
        }

        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set { SetPropertyValue<DateTime>(nameof(Date), ref _Date, value); }
        }

        private string _Who;
        [Size(10)]
        public string Who
        {
            get { return _Who; }
            set { SetPropertyValue<string>(nameof(Who), ref _Who, value); }
        }

        private string _Notes;
        [Size(SizeAttribute.Unlimited)]
        public string Notes
        {
            get { return _Notes; }
            set { SetPropertyValue<string>(nameof(Notes), ref _Notes, value); }
        }

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }

        private int _ApplKey;
        public int ApplKey
        {
            get { return _ApplKey; }
            set { SetPropertyValue<int>(nameof(ApplKey), ref _ApplKey, value); }
        }

        private string _ApplId;
        [Size(1)]
        public string ApplId
        {
            get { return _ApplId; }
            set { SetPropertyValue<string>(nameof(ApplId), ref _ApplId, value); }
        }

        private bool _Discard;
        public bool Discard
        {
            get { return _Discard; }
            set { SetPropertyValue<bool>(nameof(Discard), ref _Discard, value); }
        }

        private string _Action;
        [Size(1)]
        public string Action
        {
            get { return _Action; }
            set { SetPropertyValue<string>(nameof(Action), ref _Action, value); }
        }

        private DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }


    }
}