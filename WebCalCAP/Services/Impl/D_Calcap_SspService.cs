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
    /// services.AddScoped<ID_Calcap_SspService, D_Calcap_SspService>();
    /// </summary>
	public class D_Calcap_SspService : PbServiceBase<D_Calcap_Ssp>, ID_Calcap_SspService
	{
		public D_Calcap_SspService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Calcap_Ssp>> RetrieveAsync(double? a_ssp_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcap_Ssp>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_ssp_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}