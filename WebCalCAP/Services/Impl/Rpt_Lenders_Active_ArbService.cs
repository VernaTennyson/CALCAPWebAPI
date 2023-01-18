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
    /// services.AddScoped<IRpt_Lenders_Active_ArbService, Rpt_Lenders_Active_ArbService>();
    /// </summary>
	public class Rpt_Lenders_Active_ArbService : IRpt_Lenders_Active_ArbService
	{
		private readonly DataContext _dataContext;
			
		public Rpt_Lenders_Active_ArbService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Rpt_Lenders_Active_Arb>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, string a_loan_program, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Rpt_Lenders_Active_Arb>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_begin_dt, a_end_dt, a_loan_program }, cancellationToken);
		 
			return dataStore;
		}	
    }
}