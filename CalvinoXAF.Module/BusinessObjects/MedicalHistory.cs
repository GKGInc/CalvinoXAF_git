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
    public class MedicalHistory : CustomBaseObject
    { 
        public MedicalHistory(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

	    //[medhist_key] [int] NOT NULL,
	    //[appl_key] [int] NOT NULL,
	    //[appl_id] [char](2) NOT NULL,
	    //[medhist] [text] NOT NULL,
	    //[filler] [bit] NOT NULL,
	    //[timestamp_column] [timestamp] NOT NULL,

        private int _MedicalHistoryKey;
        public int MedicalHistoryKey
        {
            get { return _MedicalHistoryKey; }
            set { SetPropertyValue<int>(nameof(MedicalHistoryKey), ref _MedicalHistoryKey, value); }
        }

        private int _ApplicantKey;
        public int ApplicantKey
        {
            get { return _ApplicantKey; }
            set { SetPropertyValue<int>(nameof(ApplicantKey), ref _ApplicantKey, value); }
        }

        private string _ApplicantId;
        [Size(10)]
        public string ApplicantId
        {
            get { return _ApplicantId; }
            set { SetPropertyValue<string>(nameof(ApplicantId), ref _ApplicantId, value); }
        }

        private string _MedicalHistoryDesc;
        [Size(SizeAttribute.Unlimited)]
        [XafDisplayName("Medical History")]
        public string MedicalHistoryDesc
        {
            get { return _MedicalHistoryDesc; }
            set { SetPropertyValue<string>(nameof(MedicalHistoryDesc), ref _MedicalHistoryDesc, value); }
        }


        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        public DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }

    }
}