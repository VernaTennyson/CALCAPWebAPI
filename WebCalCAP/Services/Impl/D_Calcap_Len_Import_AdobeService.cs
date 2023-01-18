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
    /// services.AddScoped<ID_Calcap_Len_Import_AdobeService, D_Calcap_Len_Import_AdobeService>();
    /// </summary>
	public class D_Calcap_Len_Import_AdobeService : PbServiceBase<D_Calcap_Len_Import_Adobe>, ID_Calcap_Len_Import_AdobeService
	{
		public D_Calcap_Len_Import_AdobeService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Calcap_Len_Import_Adobe>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcap_Len_Import_Adobe>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}