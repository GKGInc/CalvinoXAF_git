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
    public class Defendants : CustomBaseObject
    { 
        public Defendants(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

	    //[defend_key] [int] NOT NULL,
	    //[appl_key] [int] NOT NULL,
	    //[appl_id] [char](1) NOT NULL,
	    //[id_type] [char](1) NOT NULL,
	    //[l_name] [char](100) NOT NULL,
	    //[f_name] [char](30) NOT NULL,
	    //[m_name] [char](30) NOT NULL,
	    //[addr1] [char](35) NOT NULL,
	    //[addr2] [char](35) NOT NULL,
	    //[city] [char](15) NOT NULL,
	    //[state] [char](2) NOT NULL,
	    //[zip] [char](10) NOT NULL,
	    //[phone_h] [char](12) NOT NULL,
	    //[phone_w] [char](12) NOT NULL,
	    //[ssn] [char](9) NOT NULL,
	    //[old_rec] [char](75) NOT NULL,
	    //[involment] [char](55) NOT NULL,
	    //[comment] [char](30) NOT NULL,
	    //[ints] [char](25) NOT NULL,
	    //[rfp] [char](25) NOT NULL,
	    //[depo] [char](25) NOT NULL,
	    //[rec_ints] [char](25) NOT NULL,
	    //[rec_rfp] [char](25) NOT NULL,
	    //[email] [char](70) NOT NULL,

        private int _DefendentKey;
        public int DefendentKey
        {
            get { return _DefendentKey; }
            set { SetPropertyValue<int>(nameof(DefendentKey), ref _DefendentKey, value); }
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
        [Size(100)]
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

        private string _WorkPhone;
        [Size(12)]
        public string WorkPhone
        {
            get { return _WorkPhone; }
            set { SetPropertyValue<string>(nameof(WorkPhone), ref _WorkPhone, value); }
        }

        private string _HomePhone;
        [Size(12)]
        public string HomePhone
        {
            get { return _HomePhone; }
            set { SetPropertyValue<string>(nameof(HomePhone), ref _HomePhone, value); }
        }

        private string _SSN;
        [Size(11)]
        public string SSN
        {
            get { return _SSN; }
            set { SetPropertyValue<string>(nameof(SSN), ref _SSN, value); }
        }


        private string _OldRec;
        [Size(75)]
        public string OldRec
        {
            get { return _OldRec; }
            set { SetPropertyValue<string>(nameof(OldRec), ref _OldRec, value); }
        }

        private string _Involment;
        [Size(55)]
        public string Involment
        {
            get { return _Involment; }
            set { SetPropertyValue<string>(nameof(Involment), ref _Involment, value); }
        }

        private string _Comment;
        [Size(200)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValue<string>(nameof(Comment), ref _Comment, value); }
        }

        private string _Ints;
        [Size(25)]
        public string Ints
        {
            get { return _Ints; }
            set { SetPropertyValue<string>(nameof(Ints), ref _Ints, value); }
        }

        private string _Rfp;
        [Size(25)]
        public string Rfp
        {
            get { return _Rfp; }
            set { SetPropertyValue<string>(nameof(Rfp), ref _Rfp, value); }
        }

        private string _Depo;
        [Size(25)]
        public string Depo
        {
            get { return _Depo; }
            set { SetPropertyValue<string>(nameof(Depo), ref _Depo, value); }
        }

        private string _RecInts;
        [Size(25)]
        public string RecInts
        {
            get { return _RecInts; }
            set { SetPropertyValue<string>(nameof(RecInts), ref _RecInts, value); }
        }

        private string _Rec_Rfp;
        [Size(25)]
        public string Rec_Rfp
        {
            get { return _Rec_Rfp; }
            set { SetPropertyValue<string>(nameof(Rec_Rfp), ref _Rec_Rfp, value); }
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