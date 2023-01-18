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
    /// services.AddScoped<ID_ArbService, D_ArbService>();
    /// </summary>
	public class D_ArbService : PbServiceBase<D_Arb>, ID_ArbService
	{
		public D_ArbService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Arb>> RetrieveAsync(double? loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Arb>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}