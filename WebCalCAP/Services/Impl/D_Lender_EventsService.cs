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
    /// services.AddScoped<ID_Lender_EventsService, D_Lender_EventsService>();
    /// </summary>
	public class D_Lender_EventsService : PbServiceBase<D_Lender_Events>, ID_Lender_EventsService
	{
		public D_Lender_EventsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Lender_Events>> RetrieveAsync(double? a_len_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Lender_Events>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_len_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}