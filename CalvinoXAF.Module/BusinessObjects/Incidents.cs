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
    public class Incidents : CustomBaseObject
    { 
        public Incidents(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[incident_key] [int] NOT NULL,
        //[ind_date] [datetime] NOT NULL,
        //[client_key] [int] NOT NULL,
        //[appl_key] [int] NOT NULL,
        //[appl_id] [char](1) NOT NULL,
        //[descrip] [char](60) NOT NULL,
        //[case_id] [int] NOT NULL,
        //[close_caseno] [char](10) NOT NULL,
        //[close_date] [datetime] NOT NULL,
        //[l_name] [char](30) NOT NULL,
        //[f_name] [char](30) NOT NULL,
        //[m_name] [char](30) NOT NULL,
        //[addr1] [char](35) NOT NULL,
        //[addr2] [char](35) NOT NULL,
        //[city] [char](15) NOT NULL,
        //[state] [char](2) NOT NULL,
        //[zip] [char](10) NOT NULL,
        //[phone] [char](20) NOT NULL,
        //[email] [char](70) NOT NULL,

        private int _IncidentKey;
        public int IncidentKey
        {
            get { return _IncidentKey; }
            set { SetPropertyValue<int>(nameof(IncidentKey), ref _IncidentKey, value); }
        }

        public DateTime _IncidentDate;
        public DateTime IncidentDate
        {
            get { return _IncidentDate; }
            set { SetPropertyValue<DateTime>(nameof(IncidentDate), ref _IncidentDate, value); }
        }

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
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

        private string _Description;
        [Size(200)]
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>(nameof(Description), ref _Description, value); }
        }

        private int _CaseId;
        public int CaseId
        {
            get { return _CaseId; }
            set { SetPropertyValue<int>(nameof(CaseId), ref _CaseId, value); }
        }

        private string _CloseCaseno;
        [Size(12)]
        public string CloseCaseno
        {
            get { return _CloseCaseno; }
            set { SetPropertyValue<string>(nameof(CloseCaseno), ref _CloseCaseno, value); }
        }

        public DateTime _CloseDate;
        public DateTime CloseDate
        {
            get { return _CloseDate; }
            set { SetPropertyValue<DateTime>(nameof(CloseDate), ref _CloseDate, value); }
        }

        private string _LastName;
        [Size(45)]
        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref _LastName, value); }
        }

        private string _FirstName;
        [Size(30)]
        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref _FirstName, value); }
        }

        private string _MiddleName;
        [Size(30)]
        public string MiddleName
        {
            get { return _MiddleName; }
            set { SetPropertyValue<string>(nameof(MiddleName), ref _MiddleName, value); }
        }

        private string _Address1;
        [Size(35)]
        public string Address1
        {
            get { return _Address1; }
            set { SetPropertyValue<string>(nameof(Address1), ref _Address1, value); }
        }

        private string _Address2;
        [Size(35)]
        public string Address2
        {
            get { return _Address2; }
            set { SetPropertyValue<string>(nameof(Address2), ref _Address2, value); }
        }

        private string _City;
        [Size(18)]
        public string City
        {
            get { return _City; }
            set { SetPropertyValue<string>(nameof(City), ref _City, value); }
        }

        private string _State;
        [Size(2)]
        public string State
        {
            get { return _State; }
            set { SetPropertyValue<string>(nameof(State), ref _State, value); }
        }

        private string _ZipCode;
        [Size(10)]
        public string ZipCode
        {
            get { return _ZipCode; }
            set { SetPropertyValue<string>(nameof(ZipCode), ref _ZipCode, value); }
        }

        private string _Phone;
        [Size(35)]
        public string Phone
        {
            get { return _Phone; }
            set { SetPropertyValue<string>(nameof(Phone), ref _Phone, value); }
        }

        private string _Email;
        [Size(70)]
        public string Email
        {
            get { return _Email; }
            set { SetPropertyValue<string>(nameof(Email), ref _Email, value); }
        }

    }
}