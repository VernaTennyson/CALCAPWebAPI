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
    /// services.AddScoped<ID_Calcapweb_Ssbci_SearchService, D_Calcapweb_Ssbci_SearchService>();
    /// </summary>
	public class D_Calcapweb_Ssbci_SearchService : ID_Calcapweb_Ssbci_SearchService
	{
		private readonly DataContext _dataContext;
			
		public D_Calcapweb_Ssbci_SearchService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Calcapweb_Ssbci_Search>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcapweb_Ssbci_Search>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}