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
    public class Dependants : CustomBaseObject
    { 
        public Dependants(Session session)
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
        //[depend_key] [int] NOT NULL,
        //[dep_name] [char](40) NOT NULL,
        //[dep_dob] [datetime] NOT NULL,

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

        private int _DependKey;
        public int DependKey
        {
            get { return _DependKey; }
            set { SetPropertyValue<int>(nameof(DependKey), ref _DependKey, value); }
        }

        private string _DependName;
        [Size(40)]
        public string DependName
        {
            get { return _DependName; }
            set { SetPropertyValue<string>(nameof(DependName), ref _DependName, value); }
        }

        private DateTime _DependDOB;
        public DateTime DependDOB
        {
            get { return _DependDOB; }
            set { SetPropertyValue<DateTime>(nameof(DependDOB), ref _DependDOB, value); }
        }
    }
}