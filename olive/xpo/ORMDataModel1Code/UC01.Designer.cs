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

    public partial class UC01 : XPBaseObject
    {
        string fUC001;
        [Key]
        [Size(10)]
        public string UC001
        {
            get { return fUC001; }
            set { SetPropertyValue<string>(nameof(UC001), ref fUC001, value); }
        }
        string fUC002;
        [Size(20)]
        public string UC002
        {
            get { return fUC002; }
            set { SetPropertyValue<string>(nameof(UC002), ref fUC002, value); }
        }
        string fUC003;
        [Size(20)]
        public string UC003
        {
            get { return fUC003; }
            set { SetPropertyValue<string>(nameof(UC003), ref fUC003, value); }
        }
        string fUC004;
        [Size(200)]
        public string UC004
        {
            get { return fUC004; }
            set { SetPropertyValue<string>(nameof(UC004), ref fUC004, value); }
        }
        char fSTATUS;
        public char STATUS
        {
            get { return fSTATUS; }
            set { SetPropertyValue<char>(nameof(STATUS), ref fSTATUS, value); }
        }
    }

}
