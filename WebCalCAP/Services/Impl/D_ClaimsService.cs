using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using SnapObjects.Data;
using DWNet.Data;
using WebCalCAP;
using WebCalCAP.Models;

namespace WebCalCAP.Services.Impl
{
    /// <summary>
	/// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<ID_ClaimsService, D_ClaimsService>();
    /// </summary>
	public class D_ClaimsService : PbServiceBase<D_Claims>, ID_ClaimsService
	{
		public D_ClaimsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Claims>> RetrieveAsync(double? loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Claims>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}