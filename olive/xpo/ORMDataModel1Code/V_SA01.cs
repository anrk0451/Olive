using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace olive.xpo.orcl
{

    public partial class V_SA01
    {
        public V_SA01(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
