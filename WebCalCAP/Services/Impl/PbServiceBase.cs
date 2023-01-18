using System;
using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using DWNet.Data;

namespace WebCalCAP.Services.Impl
{
    public abstract class PbServiceBase<TModel> : IPbServiceBase<TModel>
    {
        protected readonly DataContext _dataContext;

        public PbServiceBase(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
		
        public async Task<int> UpdateAsync(IDataStore<TModel> dataStore,CancellationToken cancellationToken)
        {
            dataStore.DataContext = _dataContext;

            return await dataStore.UpdateAsync(cancellationToken);
        }
    }
}