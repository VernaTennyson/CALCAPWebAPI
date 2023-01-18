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
    /// services.AddScoped<ID_RecoveriesService, D_RecoveriesService>();
    /// </summary>
	public class D_RecoveriesService : PbServiceBase<D_Recoveries>, ID_RecoveriesService
	{
		public D_RecoveriesService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Recoveries>> RetrieveAsync(double? a_loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Recoveries>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}