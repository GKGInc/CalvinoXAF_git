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
    public class ClientInfo : CustomBaseObject
    { 
        public ClientInfo(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[client_key] [int] NOT NULL,    
        //[clntinfo_key] [int] NOT NULL,    
        //[label_info] [char](20) NOT NULL,    
        //[text_info] [char](50) NOT NULL,

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }

        private int _ClientInfoKey;
        public int ClientInfoKey
        {
            get { return _ClientInfoKey; }
            set { SetPropertyValue<int>(nameof(ClientInfoKey), ref _ClientInfoKey, value); }
        }

        private string _LabelInfo;
        [Size(20)]
        public string LabelInfo
        {
            get { return _LabelInfo; }
            set { SetPropertyValue<string>(nameof(LabelInfo), ref _LabelInfo, value); }
        }

        private string _TextInfo;
        [Size(50)]
        public string TextInfo
        {
            get { return _TextInfo; }
            set { SetPropertyValue<string>(nameof(TextInfo), ref _TextInfo, value); }
        }

    }
}