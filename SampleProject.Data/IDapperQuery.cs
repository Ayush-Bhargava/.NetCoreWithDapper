﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Data
{
    public interface IDapperQuery
    {
        Task<IEnumerable<TReturn>> QueryListFromProcAsync<TReturn>(string sproc, object parameters);
        Task<TReturn> QueryStoredProcAsync<TReturn>(string sproc, object paramerters);
    }
}
