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
    /// services.AddScoped<ID_Arb_OrigService, D_Arb_OrigService>();
    /// </summary>
	public class D_Arb_OrigService : PbServiceBase<D_Arb_Orig>, ID_Arb_OrigService
	{
		public D_Arb_OrigService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Arb_Orig>> RetrieveAsync(double? loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Arb_Orig>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}