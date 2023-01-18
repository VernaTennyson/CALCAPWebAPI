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
    /// services.AddScoped<ID_Abs_Reb_EventsService, D_Abs_Reb_EventsService>();
    /// </summary>
	public class D_Abs_Reb_EventsService : PbServiceBase<D_Abs_Reb_Events>, ID_Abs_Reb_EventsService
	{
		public D_Abs_Reb_EventsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Reb_Events>> RetrieveAsync(double? a_cla_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Reb_Events>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_cla_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}