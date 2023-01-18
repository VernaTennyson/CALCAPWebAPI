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
    /// services.AddScoped<IDddw_Arb_Loan_TypeService, Dddw_Arb_Loan_TypeService>();
    /// </summary>
	public class Dddw_Arb_Loan_TypeService : IDddw_Arb_Loan_TypeService
	{
		private readonly DataContext _dataContext;
			
		public Dddw_Arb_Loan_TypeService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Dddw_Arb_Loan_Type>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Dddw_Arb_Loan_Type>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}