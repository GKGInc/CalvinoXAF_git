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
    public class PropertyDamage : CustomBaseObject
    { 
        public PropertyDamage(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

	    //[pro_dam_key] [int] NOT NULL,
	    //[appl_key] [int] NOT NULL,
	    //[appl_id] [char](1) NOT NULL,
	    //[owner] [char](30) NOT NULL,
	    //[relation] [char](20) NOT NULL,
	    //[color] [char](15) NOT NULL,
	    //[year_made] [char](15) NOT NULL,
	    //[make] [char](20) NOT NULL,
	    //[model] [char](20) NOT NULL,
	    //[reg_state] [char](2) NOT NULL,
	    //[reg_type] [char](10) NOT NULL,
	    //[reg_no] [char](15) NOT NULL,
	    //[date_pur] [char](20) NOT NULL,
	    //[pur_price] [numeric](7, 2) NOT NULL,
	    //[reg_price] [numeric](7, 2) NOT NULL,
	    //[pur_from] [char](60) NOT NULL,
	    //[ic_est] [numeric](7, 2) NOT NULL,
	    //[priv_est] [numeric](7, 2) NOT NULL,
	    //[part_dam] [text] NOT NULL,
	    //[auto_body] [text] NOT NULL,
	    //[veh_rep] [char](1) NOT NULL,
	    //[rep_by] [char](20) NOT NULL,
	    //[pd_claim] [char](1) NOT NULL,
	    //[claim_amt] [numeric](7, 2) NOT NULL,
	    //[liab_coll] [char](20) NOT NULL,
	    //[name_add] [text] NOT NULL,
	    //[adjuster] [char](45) NOT NULL,
	    //[adj_phone] [char](20) NOT NULL,
	    //[adj_claimno] [char](20) NOT NULL,
	    //[towamt] [numeric](7, 2) NOT NULL,
	    //[towby] [text] NOT NULL,
	    //[towpaid] [char](1) NOT NULL,
	    //[tpaidamt] [numeric](7, 2) NOT NULL,
	    //[tpaidby] [char](25) NOT NULL,
	    //[storeamt] [numeric](7, 2) NOT NULL,
	    //[storeby] [text] NOT NULL,
	    //[storepaid] [char](1) NOT NULL,
	    //[spaidamt] [numeric](7, 2) NOT NULL,
	    //[spaidby] [char](25) NOT NULL,
	    //[rentamt] [numeric](7, 2) NOT NULL,
	    //[rentby] [text] NOT NULL,
	    //[rentpaid] [char](1) NOT NULL,
	    //[rpaidamt] [numeric](7, 2) NOT NULL,
	    //[rpaidby] [char](25) NOT NULL,
	    //[rrate] [char](15) NOT NULL,
	    //[filler] [char](1) NOT NULL,
	    //[seenat] [text] NOT NULL,
	    //[client_reimb] [char](10) NOT NULL,
	    //[other_pd] [text] NOT NULL,
	    //[timestamp_column] [timestamp] NOT NULL,

        private int _PropertyDamageKey;
        public int PropertyDamageKey
        {
            get { return _PropertyDamageKey; }
            set { SetPropertyValue<int>(nameof(PropertyDamageKey), ref _PropertyDamageKey, value); }
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

        private string _Owner;
        [Size(45)]
        public string Owner
        {
            get { return _Owner; }
            set { SetPropertyValue<string>(nameof(Owner), ref _Owner, value); }
        }

        private string _Relation;
        [Size(30)]
        public string Relation
        {
            get { return _Relation; }
            set { SetPropertyValue<string>(nameof(Relation), ref _Relation, value); }
        }

        private string _Color;
        [Size(30)]
        public string Color
        {
            get { return _Color; }
            set { SetPropertyValue<string>(nameof(Color), ref _Color, value); }
        }

        private string _YearMade;
        [Size(15)]
        public string YearMade
        {
            get { return _YearMade; }
            set { SetPropertyValue<string>(nameof(YearMade), ref _YearMade, value); }
        }

        private string _Make;
        [Size(35)]
        public string Make
        {
            get { return _Make; }
            set { SetPropertyValue<string>(nameof(Make), ref _Make, value); }
        }

        private string _Model;
        [Size(35)]
        public string Model
        {
            get { return _Model; }
            set { SetPropertyValue<string>(nameof(Model), ref _Model, value); }
        }

        private string _RegistrationState;
        [Size(2)]
        public string RegistrationState
        {
            get { return _RegistrationState; }
            set { SetPropertyValue<string>(nameof(RegistrationState), ref _RegistrationState, value); }
        }

        private string _RegistrationType;
        [Size(18)]
        public string RegistrationType
        {
            get { return _RegistrationType; }
            set { SetPropertyValue<string>(nameof(RegistrationType), ref _RegistrationType, value); }
        }

        private string _RegistrationNo;
        [Size(20)]
        public string RegistrationNo
        {
            get { return _RegistrationNo; }
            set { SetPropertyValue<string>(nameof(RegistrationNo), ref _RegistrationNo, value); }
        }

        private string _DatePurchace;
        [Size(35)]
        public string DatePurchace
        {
            get { return _DatePurchace; }
            set { SetPropertyValue<string>(nameof(DatePurchace), ref _DatePurchace, value); }
        }

        private decimal _PurchasePrice;
        [Size(11)]
        public decimal PurchasePrice
        {
            get { return _PurchasePrice; }
            set { SetPropertyValue<decimal>(nameof(PurchasePrice), ref _PurchasePrice, value); }
        }

        private decimal _RegularPrice;
        [Size(11)]
        public decimal RegularPrice
        {
            get { return _RegularPrice; }
            set { SetPropertyValue<decimal>(nameof(RegularPrice), ref _RegularPrice, value); }
        }

        private string _PurchaceFrom;
        [Size(70)]
        public string PurchaceFrom
        {
            get { return _PurchaceFrom; }
            set { SetPropertyValue<string>(nameof(PurchaceFrom), ref _PurchaceFrom, value); }
        }

        private decimal _ic_est;
        [Size(11)]
        public decimal ic_est
        {
            get { return _ic_est; }
            set { SetPropertyValue<decimal>(nameof(ic_est), ref _ic_est, value); }
        }

        private decimal _priv_est;
        [Size(11)]
        public decimal priv_est
        {
            get { return _priv_est; }
            set { SetPropertyValue<decimal>(nameof(priv_est), ref _priv_est, value); }
        }
        
        private string _PartDamage;
        [Size(SizeAttribute.Unlimited)]
        public string PartDamage
        {
            get { return _PartDamage; }
            set { SetPropertyValue<string>(nameof(PartDamage), ref _PartDamage, value); }
        }

        private string _AutoBody;
        [Size(SizeAttribute.Unlimited)]
        public string AutoBody
        {
            get { return _AutoBody; }
            set { SetPropertyValue<string>(nameof(AutoBody), ref _AutoBody, value); }
        }

        private string _VehicleRep;
        [Size(1)]
        public string VehicleRep
        {
            get { return _VehicleRep; }
            set { SetPropertyValue<string>(nameof(VehicleRep), ref _VehicleRep, value); }
        }

        private string _RepBy;
        [Size(35)]
        public string RepBy
        {
            get { return _RepBy; }
            set { SetPropertyValue<string>(nameof(RepBy), ref _RepBy, value); }
        }

        private string _PDClaim;
        [Size(1)]
        public string PDClaim
        {
            get { return _PDClaim; }
            set { SetPropertyValue<string>(nameof(PDClaim), ref _PDClaim, value); }
        }

        private decimal _ClaimAmount;
        [Size(11)]
        public decimal ClaimAmount
        {
            get { return _ClaimAmount; }
            set { SetPropertyValue<decimal>(nameof(ClaimAmount), ref _ClaimAmount, value); }
        }

        private string _LiableColl;
        [Size(70)]
        public string LiableColl
        {
            get { return _LiableColl; }
            set { SetPropertyValue<string>(nameof(LiableColl), ref _LiableColl, value); }
        }

        private string _NameAdd;
        [Size(SizeAttribute.Unlimited)]
        public string NameAdd
        {
            get { return _NameAdd; }
            set { SetPropertyValue<string>(nameof(NameAdd), ref _NameAdd, value); }
        }

        private string _Adjuster;
        [Size(60)]
        public string Adjuster
        {
            get { return _Adjuster; }
            set { SetPropertyValue<string>(nameof(Adjuster), ref _Adjuster, value); }
        }

        private string _AdjusterPhone;
        [Size(20)]
        public string AdjusterPhone
        {
            get { return _AdjusterPhone; }
            set { SetPropertyValue<string>(nameof(AdjusterPhone), ref _AdjusterPhone, value); }
        }

        private string _AdjusterClaimNo;
        [Size(20)]
        public string AdjusterClaimNo
        {
            get { return _AdjusterClaimNo; }
            set { SetPropertyValue<string>(nameof(AdjusterClaimNo), ref _AdjusterClaimNo, value); }
        }

        private decimal _TowAmount;
        [Size(11)]
        public decimal TowAmount
        {
            get { return _TowAmount; }
            set { SetPropertyValue<decimal>(nameof(TowAmount), ref _TowAmount, value); }
        }

        private string _TowBy;
        [Size(SizeAttribute.Unlimited)]
        public string TowBy
        {
            get { return _TowBy; }
            set { SetPropertyValue<string>(nameof(TowBy), ref _TowBy, value); }
        }

        private string _TowPaid;
        [Size(1)]
        public string TowPaid
        {
            get { return _TowPaid; }
            set { SetPropertyValue<string>(nameof(TowPaid), ref _TowPaid, value); }
        }

        private string _TTowPaid;
        [Size(1)]
        public string TTowPaid
        {
            get { return _TTowPaid; }
            set { SetPropertyValue<string>(nameof(TTowPaid), ref _TTowPaid, value); }
        }

        private decimal _TTowDamages;
        [Size(11)]
        public decimal TTowDamages
        {
            get { return _TTowDamages; }
            set { SetPropertyValue<decimal>(nameof(TTowDamages), ref _TTowDamages, value); }
        }

        private string _TPaidBy;
        [Size(SizeAttribute.Unlimited)]
        public string TPaidBy
        {
            get { return _TPaidBy; }
            set { SetPropertyValue<string>(nameof(TPaidBy), ref _TPaidBy, value); }
        }

        private decimal _StoreAmount;
        [Size(11)]
        public decimal StoreAmount
        {
            get { return _StoreAmount; }
            set { SetPropertyValue<decimal>(nameof(StoreAmount), ref _StoreAmount, value); }
        }

        private string _StoreBy;
        [Size(SizeAttribute.Unlimited)]
        public string StoreBy
        {
            get { return _StoreBy; }
            set { SetPropertyValue<string>(nameof(StoreBy), ref _StoreBy, value); }
        }

        private string _StorePaid;
        [Size(1)]
        public string StorePaid
        {
            get { return _StorePaid; }
            set { SetPropertyValue<string>(nameof(StorePaid), ref _StorePaid, value); }
        }

        private decimal _StorePaidAmount;
        [Size(11)]
        public decimal StorePaidAmount
        {
            get { return _StorePaidAmount; }
            set { SetPropertyValue<decimal>(nameof(StorePaidAmount), ref _StorePaidAmount, value); }
        }

        private string _StorePaidBy;
        [Size(30)]
        public string StorePaidBy
        {
            get { return _StorePaidBy; }
            set { SetPropertyValue<string>(nameof(StorePaidBy), ref _StorePaidBy, value); }
        }

        private decimal _RentAmount;
        [Size(11)]
        public decimal RentAmount
        {
            get { return _RentAmount; }
            set { SetPropertyValue<decimal>(nameof(RentAmount), ref _RentAmount, value); }
        }

        private string _RentBy;
        [Size(SizeAttribute.Unlimited)]
        public string RentBy
        {
            get { return _RentBy; }
            set { SetPropertyValue<string>(nameof(RentBy), ref _RentBy, value); }
        }
        private string _RentPaid;
        [Size(1)]
        public string RentPaid
        {
            get { return _RentPaid; }
            set { SetPropertyValue<string>(nameof(RentPaid), ref _RentPaid, value); }
        }

        private decimal _RentPaidAmount;
        [Size(11)]
        public decimal RentPaidAmount
        {
            get { return _RentPaidAmount; }
            set { SetPropertyValue<decimal>(nameof(RentPaidAmount), ref _RentPaidAmount, value); }
        }

        private string _RentPaidBy;
        [Size(30)]
        public string RentPaidBy
        {
            get { return _RentPaidBy; }
            set { SetPropertyValue<string>(nameof(RentPaidBy), ref _RentPaidBy, value); }
        }

        private string _RRate;
        [Size(8)]
        public string RRate
        {
            get { return _RRate; }
            set { SetPropertyValue<string>(nameof(RRate), ref _RRate, value); }
        }

        private bool _Filler;
        public bool Filler
        {
            get { return _Filler; }
            set { SetPropertyValue<bool>(nameof(Filler), ref _Filler, value); }
        }

        private string _Seenat;
        [Size(SizeAttribute.Unlimited)]
        public string Seenat
        {
            get { return _Seenat; }
            set { SetPropertyValue<string>(nameof(Seenat), ref _Seenat, value); }
        }

        private string _ClientReimbursement;
        [Size(15)]
        public string ClientReimbursement
        {
            get { return _ClientReimbursement; }
            set { SetPropertyValue<string>(nameof(ClientReimbursement), ref _ClientReimbursement, value); }
        }

        private string _OtherPd;
        [Size(SizeAttribute.Unlimited)]
        public string OtherPd
        {
            get { return _OtherPd; }
            set { SetPropertyValue<string>(nameof(OtherPd), ref _OtherPd, value); }
        }

        private DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }

    }
}