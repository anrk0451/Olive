using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace olive.xpo.orcl
{

    public partial class REFUND
    {
        public REFUND(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
