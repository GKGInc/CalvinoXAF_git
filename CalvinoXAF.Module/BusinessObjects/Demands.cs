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
    public class Demands : CustomBaseObject
    { 
        public Demands(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

	    //[demand_key] [int] NOT NULL,
	    //[appl_key] [int] NOT NULL,
	    //[appl_id] [char](1) NOT NULL,
	    //[id_type] [char](1) NOT NULL,
	    //[total_wages] [numeric](14, 2) NOT NULL,
	    //[total_med] [numeric](14, 2) NOT NULL,
	    //[total_lien] [numeric](14, 2) NOT NULL,

        private int _DemandKey;
        public int DemandKey
        {
            get { return _DemandKey; }
            set { SetPropertyValue<int>(nameof(DemandKey), ref _DemandKey, value); }
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

        private string _IdType;
        [Size(1)]
        public string IdType
        {
            get { return _IdType; }
            set { SetPropertyValue<string>(nameof(IdType), ref _IdType, value); }
        }

        private decimal _TotalWages;
        public decimal TotalWages
        {
            get { return _TotalWages; }
            set { SetPropertyValue<decimal>(nameof(TotalWages), ref _TotalWages, value); }
        }

        private decimal _TotalMed;
        public decimal TotalMed
        {
            get { return _TotalMed; }
            set { SetPropertyValue<decimal>(nameof(TotalMed), ref _TotalMed, value); }
        }

        private decimal _TotalLien;
        public decimal TotalLien
        {
            get { return _TotalLien; }
            set { SetPropertyValue<decimal>(nameof(TotalLien), ref _TotalLien, value); }
        }

    }
}