﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBulder.JS.Types
{
    public class JSDate : JSType
    {
        public override string JSTypeDef { get { return IsPromise ? "PromiseLike<Date>" : "Date"; } set { } }
    }
}
