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
    /// services.AddScoped<IRpt_Calcap_Weekly_Claims_UpdateService, Rpt_Calcap_Weekly_Claims_UpdateService>();
    /// </summary>
	public class Rpt_Calcap_Weekly_Claims_UpdateService : IRpt_Calcap_Weekly_Claims_UpdateService
	{
		private readonly DataContext _dataContext;
			
		public Rpt_Calcap_Weekly_Claims_UpdateService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Rpt_Calcap_Weekly_Claims_Update>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, string pending, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Rpt_Calcap_Weekly_Claims_Update>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_begin_dt, a_end_dt, pending }, cancellationToken);
		 
			return dataStore;
		}	
    }
}