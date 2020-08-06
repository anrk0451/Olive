using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace olive.xpo.orcl
{

    public partial class V_REPORT_TOMBDATA_SALED
    {
        public V_REPORT_TOMBDATA_SALED(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
