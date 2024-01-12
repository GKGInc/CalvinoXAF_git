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
    public class MedicalServices : CustomBaseObject
    { 
        public MedicalServices(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[appl_key] [int] NOT NULL,
        //[appl_id] [char](1) NOT NULL,
        //[id_type] [char](1) NOT NULL,
        //[provid_key] [int] NOT NULL,
        //[prov_name] [text] NOT NULL,
        //[prov_date] [datetime] NOT NULL,
        //[prov_desc] [text] NOT NULL,
        //[prov_edate] [datetime] NOT NULL,
        //[gross_amt] [numeric](9, 2) NOT NULL,
        //[net_amt] [numeric](9, 2) NOT NULL,
        //[typeservice] [char](60) NOT NULL,
        //[timestamp_column] [timestamp] NOT NULL,

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


        private int _ProvidKey;
        public int ProvidKey
        {
            get { return _ProvidKey; }
            set { SetPropertyValue<int>(nameof(ProvidKey), ref _ProvidKey, value); }
        }

        private string _ProvName;
        [Size(200)]
        public string ProvName
        {
            get { return _ProvName; }
            set { SetPropertyValue<string>(nameof(ProvName), ref _ProvName, value); }
        }

        private DateTime _ProvDate;
        public DateTime ProvDate
        {
            get { return _ProvDate; }
            set { SetPropertyValue<DateTime>(nameof(ProvDate), ref _ProvDate, value); }
        }

        private string _ProvDescription;
        [Size(SizeAttribute.Unlimited)]
        public string ProvDescription
        {
            get { return _ProvDescription; }
            set { SetPropertyValue<string>(nameof(ProvDescription), ref _ProvDescription, value); }
        }

        private DateTime _ProvEDate;
        public DateTime ProvEDate
        {
            get { return _ProvEDate; }
            set { SetPropertyValue<DateTime>(nameof(ProvEDate), ref _ProvEDate, value); }
        }

        private decimal _GrossAmount;
        public decimal GrossAmount
        {
            get { return _GrossAmount; }
            set { SetPropertyValue<decimal>(nameof(GrossAmount), ref _GrossAmount, value); }
        }

        private decimal _NetAmount;
        public decimal NetAmount
        {
            get { return _NetAmount; }
            set { SetPropertyValue<decimal>(nameof(NetAmount), ref _NetAmount, value); }
        }

        private string _TypeService;
        [Size(70)]
        public string TypeService
        {
            get { return _TypeService; }
            set { SetPropertyValue<string>(nameof(TypeService), ref _TypeService, value); }
        }

        private DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }
    }
}