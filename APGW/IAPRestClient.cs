﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APGW
{
    public interface IAPRestClient
    {
         void ExecuteRequest<T>(RequestContext<T> request);
    }
}