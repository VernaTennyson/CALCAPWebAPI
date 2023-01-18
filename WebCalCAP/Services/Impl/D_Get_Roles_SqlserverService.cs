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
    /// services.AddScoped<ID_Get_Roles_SqlserverService, D_Get_Roles_SqlserverService>();
    /// </summary>
	public class D_Get_Roles_SqlserverService : ID_Get_Roles_SqlserverService
	{
		private readonly DataContext _dataContext;
			
		public D_Get_Roles_SqlserverService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Get_Roles_Sqlserver>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Get_Roles_Sqlserver>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}