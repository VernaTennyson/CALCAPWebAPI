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
    /// services.AddScoped<ID_Calcap_CspService, D_Calcap_CspService>();
    /// </summary>
	public class D_Calcap_CspService : PbServiceBase<D_Calcap_Csp>, ID_Calcap_CspService
	{
		public D_Calcap_CspService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Calcap_Csp>> RetrieveAsync(double? a_sup_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcap_Csp>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_sup_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}