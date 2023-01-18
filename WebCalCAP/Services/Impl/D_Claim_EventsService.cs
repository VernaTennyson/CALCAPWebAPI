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
    /// services.AddScoped<ID_Claim_EventsService, D_Claim_EventsService>();
    /// </summary>
	public class D_Claim_EventsService : PbServiceBase<D_Claim_Events>, ID_Claim_EventsService
	{
		public D_Claim_EventsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Claim_Events>> RetrieveAsync(double? a_cla_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Claim_Events>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_cla_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}