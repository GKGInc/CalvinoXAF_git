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
    public class AuditedObjectWeakReference : CustomBaseObject
    { 
        public AuditedObjectWeakReference(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[Oid] [uniqueidentifier] ROWGUIDCOL NOT NULL,
        //[GuidId] [uniqueidentifier] NULL,
        //[IntId] [int] NULL,
        //[DisplayName] [nvarchar] (250) NULL,

        private string _GuidId;
        public string GuidId
        {
            get { return _GuidId; }
            set { SetPropertyValue<string>(nameof(GuidId), ref _GuidId, value); }
        }

        public int _IntId;
        public int IntId
        {
            get { return _IntId; }
            set { SetPropertyValue<int>(nameof(IntId), ref _IntId, value); }
        }

        private string _DisplayName;
        public string DisplayName
        {
            get { return _DisplayName; }
            set { SetPropertyValue<string>(nameof(DisplayName), ref _DisplayName, value); }
        }

    }
}