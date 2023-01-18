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
    /// services.AddScoped<ID_Import_IntakeService, D_Import_IntakeService>();
    /// </summary>
	public class D_Import_IntakeService : ID_Import_IntakeService
	{
		private readonly DataContext _dataContext;
			
		public D_Import_IntakeService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Import_Intake>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Import_Intake>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}