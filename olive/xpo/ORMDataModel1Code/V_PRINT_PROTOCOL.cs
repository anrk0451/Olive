using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace olive.xpo.orcl
{

    public partial class V_PRINT_PROTOCOL
    {
        public V_PRINT_PROTOCOL(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
