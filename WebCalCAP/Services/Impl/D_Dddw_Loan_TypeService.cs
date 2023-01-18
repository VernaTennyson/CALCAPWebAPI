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
    /// services.AddScoped<ID_Dddw_Loan_TypeService, D_Dddw_Loan_TypeService>();
    /// </summary>
	public class D_Dddw_Loan_TypeService : ID_Dddw_Loan_TypeService
	{
		private readonly DataContext _dataContext;
			
		public D_Dddw_Loan_TypeService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Dddw_Loan_Type>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Dddw_Loan_Type>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}