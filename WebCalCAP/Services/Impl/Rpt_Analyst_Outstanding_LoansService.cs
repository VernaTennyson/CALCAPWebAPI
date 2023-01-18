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
    /// services.AddScoped<IRpt_Analyst_Outstanding_LoansService, Rpt_Analyst_Outstanding_LoansService>();
    /// </summary>
	public class Rpt_Analyst_Outstanding_LoansService : IRpt_Analyst_Outstanding_LoansService
	{
		private readonly DataContext _dataContext;
			
		public Rpt_Analyst_Outstanding_LoansService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Rpt_Analyst_Outstanding_Loans>> RetrieveAsync(double? a_analyst_assigned, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Rpt_Analyst_Outstanding_Loans>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_analyst_assigned }, cancellationToken);
		 
			return dataStore;
		}	
    }
}