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
    /// services.AddScoped<ID_Gis_JsonService, D_Gis_JsonService>();
    /// </summary>
	public class D_Gis_JsonService : ID_Gis_JsonService
	{
		private readonly DataContext _dataContext;
			
		public D_Gis_JsonService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Gis_Json>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Gis_Json>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}