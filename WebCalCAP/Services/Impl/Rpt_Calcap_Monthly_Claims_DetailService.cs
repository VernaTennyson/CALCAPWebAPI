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
    /// services.AddScoped<IRpt_Calcap_Monthly_Claims_DetailService, Rpt_Calcap_Monthly_Claims_DetailService>();
    /// </summary>
	public class Rpt_Calcap_Monthly_Claims_DetailService : IRpt_Calcap_Monthly_Claims_DetailService
	{
		private readonly DataContext _dataContext;
			
		public Rpt_Calcap_Monthly_Claims_DetailService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Rpt_Calcap_Monthly_Claims_Detail>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Rpt_Calcap_Monthly_Claims_Detail>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_begin_dt, a_end_dt }, cancellationToken);
		 
			return dataStore;
		}	
    }
}