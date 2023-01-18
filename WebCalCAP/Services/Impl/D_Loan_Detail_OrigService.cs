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
    /// services.AddScoped<ID_Loan_Detail_OrigService, D_Loan_Detail_OrigService>();
    /// </summary>
	public class D_Loan_Detail_OrigService : PbServiceBase<D_Loan_Detail_Orig>, ID_Loan_Detail_OrigService
	{
		public D_Loan_Detail_OrigService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Loan_Detail_Orig>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Loan_Detail_Orig>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}