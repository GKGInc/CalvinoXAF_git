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
    public class ReleaseInformation : CustomBaseObject
    { 
        public ReleaseInformation(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

	    //[rel_date_id] [int] NOT NULL,
	    //[case_id] [int] NOT NULL,
	    //[descr_date] [char](30) NOT NULL,
	    //[rel_date] [datetime] NOT NULL,
	    //[filler] [bit] NOT NULL,
	    //[comments] [char](80) NOT NULL

        private int _ReleaseInformationId;
        public int ReleaseInformationId
        {
            get { return _ReleaseInformationId; }
            set { SetPropertyValue<int>(nameof(ReleaseInformationId), ref _ReleaseInformationId, value); }
        }

        private int _CaseId;
        public int CaseId
        {
            get { return _CaseId; }
            set { SetPropertyValue<int>(nameof(CaseId), ref _CaseId, value); }
        }

        private string _DescriptionDate;
        [Size(45)]
        public string DescriptionDate
        {
            get { return _DescriptionDate; }
            set { SetPropertyValue<string>(nameof(DescriptionDate), ref _DescriptionDate, value); }
        }

        public DateTime _ReleaseDate;
        public DateTime ReleaseDate
        {
            get { return _ReleaseDate; }
            set { SetPropertyValue<DateTime>(nameof(ReleaseDate), ref _ReleaseDate, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        private string _Comments;
        [Size(30)]
        public string Comments
        {
            get { return _Comments; }
            set { SetPropertyValue<string>(nameof(Comments), ref _Comments, value); }
        }

    }
}