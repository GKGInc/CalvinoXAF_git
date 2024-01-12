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
    public class Client : CustomBaseObject
    { 
        public Client(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[client_key] [int] NOT NULL,
        //[l_name] [char](45) NOT NULL,
        //[f_name] [char](30) NOT NULL,
        //[m_name] [char](30) NOT NULL,
        //[suffix] [char](10) NOT NULL,
        //[addr1] [char](35) NOT NULL,
        //[addr2] [char](35) NOT NULL,
        //[city] [char](15) NOT NULL,
        //[state] [char](2) NOT NULL,
        //[zip] [char](10) NOT NULL,
        //[phone] [char](35) NOT NULL,
        //[ssn] [char](11) NOT NULL,
        //[dob] [datetime] NOT NULL,
        //[insystem] [char](10) NOT NULL,
        //[oldfname] [char](35) NOT NULL,
        //[foundkey] [int] NOT NULL,
        //[email] [char](70) NOT NULL,
        //[LastName] [nvarchar](45) NULL,

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
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

        private string _Suffix;
        [Size(10)]
        public string Suffix
        {
            get { return _Suffix; }
            set { SetPropertyValue<string>(nameof(Suffix), ref _Suffix, value); }
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

        private string _SSN;
        [Size(11)]
        public string SSN
        {
            get { return _SSN; }
            set { SetPropertyValue<string>(nameof(SSN), ref _SSN, value); }
        }

        private DateTime _DOB;
        public DateTime DOB
        {
            get { return _DOB; }
            set { SetPropertyValue<DateTime>(nameof(DOB), ref _DOB, value); }
        }

        private string _InSystem;
        [Size(10)]
        public string InSystem
        {
            get { return _InSystem; }
            set { SetPropertyValue<string>(nameof(InSystem), ref _InSystem, value); }
        }

        private string _OldFirstName;
        [Size(35)]
        public string OldFirstName
        {
            get { return _OldFirstName; }
            set { SetPropertyValue<string>(nameof(OldFirstName), ref _OldFirstName, value); }
        }

        private int _FoundKey;
        public int FoundKey
        {
            get { return _FoundKey; }
            set { SetPropertyValue<int>(nameof(FoundKey), ref _FoundKey, value); }
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