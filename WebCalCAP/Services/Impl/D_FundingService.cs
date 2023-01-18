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
    /// services.AddScoped<ID_FundingService, D_FundingService>();
    /// </summary>
	public class D_FundingService : PbServiceBase<D_Funding>, ID_FundingService
	{
		public D_FundingService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Funding>> RetrieveAsync(double? a_loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Funding>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}