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
    /// services.AddScoped<ID_Calcapweb_SspService, D_Calcapweb_SspService>();
    /// </summary>
	public class D_Calcapweb_SspService : PbServiceBase<D_Calcapweb_Ssp>, ID_Calcapweb_SspService
	{
		public D_Calcapweb_SspService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Calcapweb_Ssp>> RetrieveAsync(double? a_ssp_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcapweb_Ssp>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_ssp_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}