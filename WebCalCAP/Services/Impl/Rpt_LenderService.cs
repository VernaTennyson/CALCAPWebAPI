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
    /// services.AddScoped<IRpt_LenderService, Rpt_LenderService>();
    /// </summary>
	public class Rpt_LenderService : IRpt_LenderService
	{
		private readonly DataContext _dataContext;
			
		public Rpt_LenderService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Rpt_Lender>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, double? a_len_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Rpt_Lender>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_begin_dt, a_end_dt, a_len_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}