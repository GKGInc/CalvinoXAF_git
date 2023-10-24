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
    public class OtherParties : CustomBaseObject
    { 
        public OtherParties(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

	    //[oth_par_key] [int] NOT NULL,
	    //[appl_key] [int] NOT NULL,
	    //[id_type] [char](1) NOT NULL,
	    //[appl_id] [char](1) NOT NULL,
	    //[l_name] [char](45) NOT NULL,
	    //[f_name] [char](30) NOT NULL,
	    //[m_name] [char](30) NOT NULL,
	    //[addr1] [char](35) NOT NULL,
	    //[addr2] [char](35) NOT NULL,
	    //[city] [char](15) NOT NULL,
	    //[state] [char](2) NOT NULL,
	    //[zip] [char](10) NOT NULL,
	    //[phone] [char](12) NOT NULL,
	    //[phone_oth] [char](12) NOT NULL,
	    //[phone_wrk] [char](12) NOT NULL,
	    //[ssn] [char](11) NOT NULL,
	    //[dob] [datetime] NOT NULL,
	    //[marital_s] [char](1) NOT NULL,
	    //[sp_name] [char](35) NOT NULL,
	    //[filler] [char](1) NOT NULL,
	    //[client_key] [int] NOT NULL,
	    //[location] [char](30) NOT NULL,
	    //[comment] [char](30) NOT NULL,
	    //[email] [char](70) NOT NULL,

        private int _OtherPartiesKey;
        public int OtherPartiesKey
        {
            get { return _OtherPartiesKey; }
            set { SetPropertyValue<int>(nameof(OtherPartiesKey), ref _OtherPartiesKey, value); }
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

        private string _PhoneOther;
        [Size(35)]
        public string PhoneOther
        {
            get { return _PhoneOther; }
            set { SetPropertyValue<string>(nameof(PhoneOther), ref _PhoneOther, value); }
        }

        private string _PhoneWork;
        [Size(35)]
        public string PhoneWork
        {
            get { return _PhoneWork; }
            set { SetPropertyValue<string>(nameof(PhoneWork), ref _PhoneWork, value); }
        }

        private string _SSN;
        [Size(11)]
        public string SSN
        {
            get { return _SSN; }
            set { SetPropertyValue<string>(nameof(SSN), ref _SSN, value); }
        }

        public DateTime _DOB;
        public DateTime DOB
        {
            get { return _DOB; }
            set { SetPropertyValue<DateTime>(nameof(DOB), ref _DOB, value); }
        }

        private string _MaritalStatus;
        [Size(1)]
        public string MaritalStatus
        {
            get { return _MaritalStatus; }
            set { SetPropertyValue<string>(nameof(MaritalStatus), ref _MaritalStatus, value); }
        }

        private string _SpouseName;
        [Size(50)]
        public string SpouseName
        {
            get { return _SpouseName; }
            set { SetPropertyValue<string>(nameof(SpouseName), ref _SpouseName, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }

        private string _Location;
        [Size(35)]
        public string Location
        {
            get { return _Location; }
            set { SetPropertyValue<string>(nameof(Location), ref _Location, value); }
        }

        private string _Comments;
        [Size(SizeAttribute.Unlimited)]
        public string Comments
        {
            get { return _Comments; }
            set { SetPropertyValue<string>(nameof(Comments), ref _Comments, value); }
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