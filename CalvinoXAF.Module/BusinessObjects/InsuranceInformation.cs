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
    public class InsuranceInformation : CustomBaseObject
    { 
        public InsuranceInformation(Session session)
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
        //[insur_key] [int] NOT NULL,
        //[insur_name] [char](35) NOT NULL,
        //[insur_phone] [char](12) NOT NULL,
        //[insur_fax] [char](12) NOT NULL,
        //[insur_addr1] [char](35) NOT NULL,
        //[insur_addr2] [char](35) NOT NULL,
        //[insur_city] [char](25) NOT NULL,
        //[insur_state] [char](2) NOT NULL,
        //[insur_zip] [char](10) NOT NULL,
        //[insur_adj] [char](20) NOT NULL,
        //[insur_clm] [char](20) NOT NULL,
        //[insur_ext] [char](6) NOT NULL,
        //[filler] [char](1) NOT NULL,
        //[health_c] [text] NOT NULL,
        //[auto_reg] [char](1) NOT NULL,
        //[ins_house] [char](1) NOT NULL,
        //[insur_h] [char](35) NOT NULL,
        //[carrier_h] [char](35) NOT NULL,
        //[addr_h] [text] NOT NULL,
        //[policy_h] [char](25) NOT NULL,
        //[relation_h] [char](35) NOT NULL,
        //[adjust_h] [char](35) NOT NULL,
        //[phone_h] [char](20) NOT NULL,
        //[fax_h] [char](15) NOT NULL,
        //[claim_h] [char](30) NOT NULL,
        //[coverage_h] [text] NOT NULL,
        //[invol_veh] [text] NOT NULL,
        //[p_ins_car] [char](35) NOT NULL,
        //[p_insured] [char](30) NOT NULL,
        //[adjust_email] [char](70) NOT NULL,
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
        private int _InsuranceKey;
        public int InsuranceKey
        {
            get { return _InsuranceKey; }
            set { SetPropertyValue<int>(nameof(InsuranceKey), ref _InsuranceKey, value); }
        }

        private string _InsuranceName;
        [Size(45)]
        public string InsuranceName
        {
            get { return _InsuranceName; }
            set { SetPropertyValue<string>(nameof(InsuranceName), ref _InsuranceName, value); }
        }

        private string _InsurancePhone;
        [Size(12)]
        public string InsurancePhone
        {
            get { return _InsurancePhone; }
            set { SetPropertyValue<string>(nameof(InsurancePhone), ref _InsurancePhone, value); }
        }

        private string _InsuranceFax;
        [Size(12)]
        public string InsuranceFax
        {
            get { return _InsuranceFax; }
            set { SetPropertyValue<string>(nameof(InsuranceFax), ref _InsuranceFax, value); }
        }

        private string _InsuranceAddress1;
        [Size(35)]
        public string InsuranceAddress1
        {
            get { return _InsuranceAddress1; }
            set { SetPropertyValue<string>(nameof(InsuranceAddress1), ref _InsuranceAddress1, value); }
        }

        private string _InsuranceAddress2;
        [Size(35)]
        public string InsuranceAddress2
        {
            get { return _InsuranceAddress2; }
            set { SetPropertyValue<string>(nameof(InsuranceAddress2), ref _InsuranceAddress2, value); }
        }

        private string _InsuranceCity;
        [Size(18)]
        public string InsuranceCity
        {
            get { return _InsuranceCity; }
            set { SetPropertyValue<string>(nameof(InsuranceCity), ref _InsuranceCity, value); }
        }

        private string _InsuranceState;
        [Size(2)]
        public string InsuranceState
        {
            get { return _InsuranceState; }
            set { SetPropertyValue<string>(nameof(InsuranceState), ref _InsuranceState, value); }
        }

        private string _InsuranceZipCode;
        [Size(10)]
        public string InsuranceZipCode
        {
            get { return _InsuranceZipCode; }
            set { SetPropertyValue<string>(nameof(InsuranceZipCode), ref _InsuranceZipCode, value); }
        }

        private string _InsuranceAdjustment;
        [Size(20)]
        public string InsuranceAdjustment
        {
            get { return _InsuranceAdjustment; }
            set { SetPropertyValue<string>(nameof(InsuranceAdjustment), ref _InsuranceAdjustment, value); }
        }

        private string _InsuranceClaim;
        [Size(20)]
        public string InsuranceClaim
        {
            get { return _InsuranceClaim; }
            set { SetPropertyValue<string>(nameof(InsuranceClaim), ref _InsuranceClaim, value); }
        }

        private string _InsuranceExt;
        [Size(6)]
        public string InsuranceExt
        {
            get { return _InsuranceExt; }
            set { SetPropertyValue<string>(nameof(InsuranceExt), ref _InsuranceExt, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        private string _HealthC;
        [Size(SizeAttribute.Unlimited)]
        public string HealthC
        {
            get { return _HealthC; }
            set { SetPropertyValue<string>(nameof(HealthC), ref _HealthC, value); }
        }

        private string _AutoReg;
        [Size(1)]
        public string AutoReg
        {
            get { return _AutoReg; }
            set { SetPropertyValue<string>(nameof(AutoReg), ref _AutoReg, value); }
        }

        private string _InsHouse;
        [Size(1)]
        public string InsHouse
        {
            get { return _InsHouse; }
            set { SetPropertyValue<string>(nameof(InsHouse), ref _InsHouse, value); }
        }

        private string _InsuranceH;
        [Size(35)]
        public string InsuranceH
        {
            get { return _InsuranceH; }
            set { SetPropertyValue<string>(nameof(InsuranceH), ref _InsuranceH, value); }
        }

        private string _CarrierH;
        [Size(35)]
        public string CarrierH
        {
            get { return _CarrierH; }
            set { SetPropertyValue<string>(nameof(CarrierH), ref _CarrierH, value); }
        }

        private string _AddrH;
        [Size(SizeAttribute.Unlimited)]
        public string AddrH
        {
            get { return _AddrH; }
            set { SetPropertyValue<string>(nameof(AddrH), ref _AddrH, value); }
        }

        private string _PolicyH;
        [Size(25)]
        public string PolicyH
        {
            get { return _PolicyH; }
            set { SetPropertyValue<string>(nameof(PolicyH), ref _PolicyH, value); }
        }

        private string _RelationH;
        [Size(35)]
        public string RelationH
        {
            get { return _RelationH; }
            set { SetPropertyValue<string>(nameof(RelationH), ref _RelationH, value); }
        }

        private string _AdjustH;
        [Size(35)]
        public string AdjustH
        {
            get { return _AdjustH; }
            set { SetPropertyValue<string>(nameof(AdjustH), ref _AdjustH, value); }
        }

        private string _PhoneH;
        [Size(20)]
        public string PhoneH
        {
            get { return _PhoneH; }
            set { SetPropertyValue<string>(nameof(PhoneH), ref _PhoneH, value); }
        }

        private string _FaxH;
        [Size(15)]
        public string FaxH
        {
            get { return _FaxH; }
            set { SetPropertyValue<string>(nameof(FaxH), ref _FaxH, value); }
        }

        private string _ClaimH;
        [Size(35)]
        public string ClaimH
        {
            get { return _ClaimH; }
            set { SetPropertyValue<string>(nameof(ClaimH), ref _ClaimH, value); }
        }

        private string _CoverageH;
        [Size(SizeAttribute.Unlimited)]
        public string CoverageH
        {
            get { return _CoverageH; }
            set { SetPropertyValue<string>(nameof(CoverageH), ref _CoverageH, value); }
        }

        private string _InvolVehicle;
        [Size(SizeAttribute.Unlimited)]
        public string InvolVehicle
        {
            get { return _InvolVehicle; }
            set { SetPropertyValue<string>(nameof(InvolVehicle), ref _InvolVehicle, value); }
        }

        private string _p_ins_car;
        [Size(35)]
        public string p_ins_car
        {
            get { return _p_ins_car; }
            set { SetPropertyValue<string>(nameof(p_ins_car), ref _p_ins_car, value); }
        }

        private string _p_insured;
        [Size(35)]
        public string p_insured
        {
            get { return _p_insured; }
            set { SetPropertyValue<string>(nameof(p_insured), ref _p_insured, value); }
        }

        private string _AdjustmentEmail;
        [Size(70)]
        public string AdjustmentEmail
        {
            get { return _AdjustmentEmail; }
            set { SetPropertyValue<string>(nameof(AdjustmentEmail), ref _AdjustmentEmail, value); }
        }

        public DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }

    }
}