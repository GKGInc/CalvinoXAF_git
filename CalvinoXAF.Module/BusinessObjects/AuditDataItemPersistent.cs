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
    public class AuditDataItemPersistent : CustomBaseObject
    { 
        public AuditDataItemPersistent(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[Oid] [uniqueidentifier] ROWGUIDCOL NOT NULL,
        //[UserName] [nvarchar] (100) NULL,
        //[ModifiedOn] [datetime] NULL,
        //[OperationType] [nvarchar] (100) NULL,
        //[Description] [nvarchar] (2048) NULL,
        //[AuditedObject] [uniqueidentifier] NULL,
        //[OldObject] [uniqueidentifier] NULL,
        //[NewObject] [uniqueidentifier] NULL,
        //[OldValue] [nvarchar] (1024) NULL,
        //[NewValue] [nvarchar] (1024) NULL,
        //[PropertyName] [nvarchar] (100) NULL,
        //[OptimisticLockField] [int] NULL,
        //[GCRecord] [int] NULL,


        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { SetPropertyValue<string>(nameof(UserName), ref _UserName, value); }
        }

        private DateTime _ModifiedOn;
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { SetPropertyValue<DateTime>(nameof(ModifiedOn), ref _ModifiedOn, value); }
        }

        private string _OperationType;
        public string OperationType
        {
            get { return _OperationType; }
            set { SetPropertyValue<string>(nameof(OperationType), ref _OperationType, value); }
        }

        private string _Description;
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>(nameof(Description), ref _Description, value); }
        }

        private string _AuditedObject;
        public string AuditedObject
        {
            get { return _AuditedObject; }
            set { SetPropertyValue<string>(nameof(AuditedObject), ref _AuditedObject, value); }
        }

        private string _OldObject;
        public string OldObject
        {
            get { return _OldObject; }
            set { SetPropertyValue<string>(nameof(OldObject), ref _OldObject, value); }
        }

        private string _NewObject;
        public string NewObject
        {
            get { return _NewObject; }
            set { SetPropertyValue<string>(nameof(NewObject), ref _NewObject, value); }
        }

        private string _OldValue;
        public string OldValue
        {
            get { return _OldValue; }
            set { SetPropertyValue<string>(nameof(OldValue), ref _OldValue, value); }
        }

        private string _NewValue;
        public string NewValue
        {
            get { return _NewValue; }
            set { SetPropertyValue<string>(nameof(NewValue), ref _NewValue, value); }
        }

        private string _PropertyName;
        public string PropertyName
        {
            get { return _PropertyName; }
            set { SetPropertyValue<string>(nameof(PropertyName), ref _PropertyName, value); }
        }



    }
}