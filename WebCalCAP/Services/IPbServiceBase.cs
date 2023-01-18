using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;

namespace WebCalCAP.Services
{
    public interface IPbServiceBase<TModel>
    {
        Task<int> UpdateAsync(IDataStore<TModel> dataStore,CancellationToken cancellationToken);
    }
}