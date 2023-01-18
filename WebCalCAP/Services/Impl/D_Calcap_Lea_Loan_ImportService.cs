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
    /// services.AddScoped<ID_Calcap_Lea_Loan_ImportService, D_Calcap_Lea_Loan_ImportService>();
    /// </summary>
	public class D_Calcap_Lea_Loan_ImportService : PbServiceBase<D_Calcap_Lea_Loan_Import>, ID_Calcap_Lea_Loan_ImportService
	{
		public D_Calcap_Lea_Loan_ImportService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Calcap_Lea_Loan_Import>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcap_Lea_Loan_Import>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}