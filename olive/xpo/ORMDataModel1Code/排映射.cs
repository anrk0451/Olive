using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace olive.xpo.orcl
{

    public partial class 排映射
    {
        public 排映射(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
