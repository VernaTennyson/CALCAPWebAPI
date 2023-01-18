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
    /// services.AddScoped<ID_Abs_Calcap_Purpose_LoanService, D_Abs_Calcap_Purpose_LoanService>();
    /// </summary>
	public class D_Abs_Calcap_Purpose_LoanService : ID_Abs_Calcap_Purpose_LoanService
	{
		private readonly DataContext _dataContext;
			
		public D_Abs_Calcap_Purpose_LoanService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Abs_Calcap_Purpose_Loan>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Calcap_Purpose_Loan>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}