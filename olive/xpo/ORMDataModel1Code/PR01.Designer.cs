﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace olive.xpo.orcl
{

    public partial class PR01 : XPLiteObject
    {
        string fPR001;
        [Key]
        [Size(10)]
        public string PR001
        {
            get { return fPR001; }
            set { SetPropertyValue<string>(nameof(PR001), ref fPR001, value); }
        }
        string fAC001;
        [Indexed(Name = @"IDX_PR01_AC001")]
        [Size(10)]
        public string AC001
        {
            get { return fAC001; }
            set { SetPropertyValue<string>(nameof(AC001), ref fAC001, value); }
        }
        DateTime fPR002;
        public DateTime PR002
        {
            get { return fPR002; }
            set { SetPropertyValue<DateTime>(nameof(PR002), ref fPR002, value); }
        }
        DateTime fPR003;
        public DateTime PR003
        {
            get { return fPR003; }
            set { SetPropertyValue<DateTime>(nameof(PR003), ref fPR003, value); }
        }
        char fPR004;
        public char PR004
        {
            get { return fPR004; }
            set { SetPropertyValue<char>(nameof(PR004), ref fPR004, value); }
        }
        decimal fPRICE;
        public decimal PRICE
        {
            get { return fPRICE; }
            set { SetPropertyValue<decimal>(nameof(PRICE), ref fPRICE, value); }
        }
        decimal fNUMS;
        public decimal NUMS
        {
            get { return fNUMS; }
            set { SetPropertyValue<decimal>(nameof(NUMS), ref fNUMS, value); }
        }
        decimal fPR007;
        public decimal PR007
        {
            get { return fPR007; }
            set { SetPropertyValue<decimal>(nameof(PR007), ref fPR007, value); }
        }
        char fPR008;
        public char PR008
        {
            get { return fPR008; }
            set { SetPropertyValue<char>(nameof(PR008), ref fPR008, value); }
        }
        string fPR100;
        [Size(10)]
        public string PR100
        {
            get { return fPR100; }
            set { SetPropertyValue<string>(nameof(PR100), ref fPR100, value); }
        }
        DateTime fPR200;
        public DateTime PR200
        {
            get { return fPR200; }
            set { SetPropertyValue<DateTime>(nameof(PR200), ref fPR200, value); }
        }
        char fSTATUS;
        [Indexed(Name = @"IDX_PR01_STATUS")]
        public char STATUS
        {
            get { return fSTATUS; }
            set { SetPropertyValue<char>(nameof(STATUS), ref fSTATUS, value); }
        }
    }

}
