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
    /// services.AddScoped<IRpt_Monthly_ActivityService, Rpt_Monthly_ActivityService>();
    /// </summary>
	public class Rpt_Monthly_ActivityService : IRpt_Monthly_ActivityService
	{
		private readonly DataContext _dataContext;
			
		public Rpt_Monthly_ActivityService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Rpt_Monthly_Activity>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Rpt_Monthly_Activity>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_begin_dt, a_end_dt }, cancellationToken);
		 
			return dataStore;
		}	
    }
}