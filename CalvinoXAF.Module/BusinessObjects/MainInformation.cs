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
    public class MainInformation : CustomBaseObject
    { 
        public MainInformation(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[main_key] [int] NOT NULL,
        //[client_key] [int] NOT NULL,
        //[adv_par1] [char](35) NOT NULL,
        //[adv_par2] [char](35) NOT NULL,
        //[dateinj] [datetime] NOT NULL,
        //[phone] [char](12) NOT NULL,
        //[stat_lim] [datetime] NOT NULL,
        //[thi_day_f] [datetime] NOT NULL,
        //[six_mo_f] [datetime] NOT NULL,
        //[the_mo_f] [datetime] NOT NULL,
        //[intake_d] [datetime] NOT NULL,
        //[closedate] [datetime] NOT NULL,
        //[close_no] [char](14) NOT NULL,
        //[pre_atty] [char](3) NOT NULL,
        //[lit_atty] [char](3) NOT NULL,
        //[co_atty] [char](3) NOT NULL,
        //[case_type] [char](15) NOT NULL,
        //[long_desc] [char](40) NOT NULL,
        //[gross_ref] [char](55) NOT NULL,
        //[comments] [text] NOT NULL,
        //[insurc_adv1] [char](50) NOT NULL,
        //[insurc_adv2] [char](50) NOT NULL,
        //[matter] [char](8) NOT NULL,
        //[state] [char](2) NOT NULL,
        //[lstatute] [char](3) NOT NULL,
        //[stat_note] [char](20) NOT NULL,
        //[timestamp_column] [timestamp] NOT NULL,

        private int _MainKey;
        public int MainKey
        {
            get { return _MainKey; }
            set { SetPropertyValue<int>(nameof(MainKey), ref _MainKey, value); }
        }

        private int _ClientKey;
        public int ClientKey
        {
            get { return _ClientKey; }
            set { SetPropertyValue<int>(nameof(ClientKey), ref _ClientKey, value); }
        }


        private string _AdvPar1;
        [Size(35)]
        public string AdvPar1
        {
            get { return _AdvPar1; }
            set { SetPropertyValue<string>(nameof(AdvPar1), ref _AdvPar1, value); }
        }

        private string _AdvPar2;
        [Size(35)]
        public string AdvPar2
        {
            get { return _AdvPar2; }
            set { SetPropertyValue<string>(nameof(AdvPar2), ref _AdvPar2, value); }
        }

        public DateTime _DateInj;
        public DateTime DateInj
        {
            get { return _DateInj; }
            set { SetPropertyValue<DateTime>(nameof(DateInj), ref _DateInj, value); }
        }

        private string _Phone;
        [Size(12)]
        public string Phone
        {
            get { return _Phone; }
            set { SetPropertyValue<string>(nameof(Phone), ref _Phone, value); }
        }

        public DateTime _StatuteOfLimitations;
        public DateTime StatuteOfLimitations
        {
            get { return _StatuteOfLimitations; }
            set { SetPropertyValue<DateTime>(nameof(StatuteOfLimitations), ref _StatuteOfLimitations, value); }
        }

        public DateTime _thi_day_f;
        public DateTime thi_day_f
        {
            get { return _thi_day_f; }
            set { SetPropertyValue<DateTime>(nameof(thi_day_f), ref _thi_day_f, value); }
        }

        public DateTime _six_mo_f;
        public DateTime six_mo_f
        {
            get { return _six_mo_f; }
            set { SetPropertyValue<DateTime>(nameof(six_mo_f), ref _six_mo_f, value); }
        }

        public DateTime _the_mo_f;
        public DateTime the_mo_f
        {
            get { return _the_mo_f; }
            set { SetPropertyValue<DateTime>(nameof(the_mo_f), ref _the_mo_f, value); }
        }

        public DateTime _IntakeDate;
        public DateTime IntakeDate
        {
            get { return _IntakeDate; }
            set { SetPropertyValue<DateTime>(nameof(IntakeDate), ref _IntakeDate, value); }
        }

        public DateTime _CloseDate;
        public DateTime CloseDate
        {
            get { return _CloseDate; }
            set { SetPropertyValue<DateTime>(nameof(CloseDate), ref _CloseDate, value); }
        }

        private string _CloseNo;
        [Size(14)]
        public string CloseNo
        {
            get { return _CloseNo; }
            set { SetPropertyValue<string>(nameof(CloseNo), ref _CloseNo, value); }
        }

        private string _PreAtty;
        [Size(3)]
        public string PreAtty
        {
            get { return _PreAtty; }
            set { SetPropertyValue<string>(nameof(PreAtty), ref _PreAtty, value); }
        }

        private string _LitAtty;
        [Size(3)]
        public string LitAtty
        {
            get { return _LitAtty; }
            set { SetPropertyValue<string>(nameof(LitAtty), ref _LitAtty, value); }
        }

        private string _CoAtty;
        [Size(3)]
        public string CoAtty
        {
            get { return _CoAtty; }
            set { SetPropertyValue<string>(nameof(CoAtty), ref _CoAtty, value); }
        }

        private string _CaseType;
        [Size(15)]
        public string CaseType
        {
            get { return _CaseType; }
            set { SetPropertyValue<string>(nameof(CaseType), ref _CaseType, value); }
        }

        private string _LongDesc;
        [Size(40)]
        public string LongDesc
        {
            get { return _LongDesc; }
            set { SetPropertyValue<string>(nameof(LongDesc), ref _LongDesc, value); }
        }

        private string _GrossRef;
        [Size(55)]
        public string GrossRef
        {
            get { return _GrossRef; }
            set { SetPropertyValue<string>(nameof(GrossRef), ref _GrossRef, value); }
        }

        private string _Comments;
        [Size(SizeAttribute.Unlimited)]
        public string Comments
        {
            get { return _Comments; }
            set { SetPropertyValue<string>(nameof(Comments), ref _Comments, value); }
        }

        private string _InsurcAdv1;
        [Size(50)]
        public string InsurcAdv1
        {
            get { return _InsurcAdv1; }
            set { SetPropertyValue<string>(nameof(InsurcAdv1), ref _InsurcAdv1, value); }
        }

        private string _InsurcAdv2;
        [Size(50)]
        public string InsurcAdv2
        {
            get { return _InsurcAdv2; }
            set { SetPropertyValue<string>(nameof(InsurcAdv2), ref _InsurcAdv2, value); }
        }

        private string _Matter;
        [Size(8)]
        public string Matter
        {
            get { return _Matter; }
            set { SetPropertyValue<string>(nameof(Matter), ref _Matter, value); }
        }

        private string _State;
        [Size(2)]
        public string State
        {
            get { return _State; }
            set { SetPropertyValue<string>(nameof(State), ref _State, value); }
        }

        private string _lstatute;
        [Size(3)]
        public string lstatute
        {
            get { return _lstatute; }
            set { SetPropertyValue<string>(nameof(lstatute), ref _lstatute, value); }
        }


        private string _StatNote;
        [Size(30)]
        public string StatNote
        {
            get { return _StatNote; }
            set { SetPropertyValue<string>(nameof(StatNote), ref _StatNote, value); }
        }


        public DateTime _Timestamp;
        public DateTime Timestamp
        {
            get { return _Timestamp; }
            set { SetPropertyValue<DateTime>(nameof(Timestamp), ref _Timestamp, value); }
        }

    }
}