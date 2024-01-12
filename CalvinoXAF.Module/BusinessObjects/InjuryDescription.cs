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
    public class InjuryDescription : CustomBaseObject
    { 
        public InjuryDescription(Session session)
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
        //[injury_key] [int] NOT NULL,
        //[injury] [text] NOT NULL,
        //[scarring] [text] NOT NULL,
        //[loss_use] [text] NOT NULL,
        //[injr_expl] [text] NOT NULL,
        //[injr_prior] [text] NOT NULL,
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

        private int _InjuryKey;
        public int InjuryKey
        {
            get { return _InjuryKey; }
            set { SetPropertyValue<int>(nameof(InjuryKey), ref _InjuryKey, value); }
        }

        private string _Injury;
        [Size(SizeAttribute.Unlimited)]
        public string Injury
        {
            get { return _Injury; }
            set { SetPropertyValue<string>(nameof(Injury), ref _Injury, value); }
        }

        private string _Scarring;
        [Size(SizeAttribute.Unlimited)]
        public string Scarring
        {
            get { return _Scarring; }
            set { SetPropertyValue<string>(nameof(Scarring), ref _Scarring, value); }
        }
        private string _LossUse;
        [Size(SizeAttribute.Unlimited)]
        public string LossUse
        {
            get { return _LossUse; }
            set { SetPropertyValue<string>(nameof(LossUse), ref _LossUse, value); }
        }
        private string _InjuryExpl;
        [Size(SizeAttribute.Unlimited)]
        public string InjuryExpl
        {
            get { return _InjuryExpl; }
            set { SetPropertyValue<string>(nameof(InjuryExpl), ref _InjuryExpl, value); }
        }
        private string _InjuryPrior;
        [Size(SizeAttribute.Unlimited)]
        public string InjuryPrior
        {
            get { return _InjuryPrior; }
            set { SetPropertyValue<string>(nameof(InjuryPrior), ref _InjuryPrior, value); }
        }

        private DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }


    }
}