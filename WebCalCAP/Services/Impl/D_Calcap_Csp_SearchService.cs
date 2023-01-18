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
    /// services.AddScoped<ID_Calcap_Csp_SearchService, D_Calcap_Csp_SearchService>();
    /// </summary>
	public class D_Calcap_Csp_SearchService : ID_Calcap_Csp_SearchService
	{
		private readonly DataContext _dataContext;
			
		public D_Calcap_Csp_SearchService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Calcap_Csp_Search>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcap_Csp_Search>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}