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
    /// services.AddScoped<ID_Calcap_EvcsService, D_Calcap_EvcsService>();
    /// </summary>
	public class D_Calcap_EvcsService : PbServiceBase<D_Calcap_Evcs>, ID_Calcap_EvcsService
	{
		public D_Calcap_EvcsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Calcap_Evcs>> RetrieveAsync(double? a_evcs_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcap_Evcs>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_evcs_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}