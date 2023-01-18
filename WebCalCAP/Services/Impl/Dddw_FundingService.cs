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
    /// services.AddScoped<IDddw_FundingService, Dddw_FundingService>();
    /// </summary>
	public class Dddw_FundingService : IDddw_FundingService
	{
		private readonly DataContext _dataContext;
			
		public Dddw_FundingService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Dddw_Funding>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Dddw_Funding>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}