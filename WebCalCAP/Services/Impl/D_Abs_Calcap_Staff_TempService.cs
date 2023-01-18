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
    /// services.AddScoped<ID_Abs_Calcap_Staff_TempService, D_Abs_Calcap_Staff_TempService>();
    /// </summary>
	public class D_Abs_Calcap_Staff_TempService : PbServiceBase<D_Abs_Calcap_Staff_Temp>, ID_Abs_Calcap_Staff_TempService
	{
		public D_Abs_Calcap_Staff_TempService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Calcap_Staff_Temp>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Calcap_Staff_Temp>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}