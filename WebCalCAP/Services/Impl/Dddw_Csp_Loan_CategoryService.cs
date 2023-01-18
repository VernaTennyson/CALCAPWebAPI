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
    /// services.AddScoped<IDddw_Csp_Loan_CategoryService, Dddw_Csp_Loan_CategoryService>();
    /// </summary>
	public class Dddw_Csp_Loan_CategoryService : IDddw_Csp_Loan_CategoryService
	{
		private readonly DataContext _dataContext;
			
		public Dddw_Csp_Loan_CategoryService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Dddw_Csp_Loan_Category>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Dddw_Csp_Loan_Category>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}