﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace olive.xpo.orcl
{

    public partial class V_FA01_SEARCH
    {
        public V_FA01_SEARCH(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
