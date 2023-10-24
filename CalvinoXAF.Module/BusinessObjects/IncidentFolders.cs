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
    public class IncidentFolders : CustomBaseObject
    { 
        public IncidentFolders(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[inc_folderid] [int] NOT NULL,
        //[incident_key] [int] NOT NULL,
        //[client_key] [int] NOT NULL,
        //[cur_name] [char](100) NOT NULL,
        //[new_name] [char](100) NOT NULL,
        //[lfoldercreated] [bit] NOT NULL,
        //[filler] [bit] NOT NULL,

        private int _IncidentFolderId;
        public int IncidentFolderId
        {
            get { return _IncidentFolderId; }
            set { SetPropertyValue<int>(nameof(IncidentFolderId), ref _IncidentFolderId, value); }
        }

        private int _IncidentKey;
        public int IncidentKey
        {
            get { return _IncidentKey; }
            set { SetPropertyValue<int>(nameof(IncidentKey), ref _IncidentKey, value); }
        }

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }

        private string _CurrentName;
        [Size(100)]
        public string CurrentName
        {
            get { return _CurrentName; }
            set { SetPropertyValue<string>(nameof(CurrentName), ref _CurrentName, value); }
        }

        private string _NewName;
        [Size(100)]
        public string NewName
        {
            get { return _NewName; }
            set { SetPropertyValue<string>(nameof(NewName), ref _NewName, value); }
        }

        private bool _FolderCreated;
        public bool FolderCreated
        {
            get { return _FolderCreated; }
            set { SetPropertyValue<bool>(nameof(FolderCreated), ref _FolderCreated, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }
    }
}