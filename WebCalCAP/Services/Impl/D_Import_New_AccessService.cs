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
    /// services.AddScoped<ID_Import_New_AccessService, D_Import_New_AccessService>();
    /// </summary>
	public class D_Import_New_AccessService : ID_Import_New_AccessService
	{
		private readonly DataContext _dataContext;
			
		public D_Import_New_AccessService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Import_New_Access>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Import_New_Access>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}