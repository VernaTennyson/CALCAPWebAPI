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
    /// services.AddScoped<ID_Loan_DetailService, D_Loan_DetailService>();
    /// </summary>
	public class D_Loan_DetailService : PbServiceBase<D_Loan_Detail>, ID_Loan_DetailService
	{
		public D_Loan_DetailService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Loan_Detail>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Loan_Detail>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}