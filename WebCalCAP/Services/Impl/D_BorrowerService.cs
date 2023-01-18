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
    /// services.AddScoped<ID_BorrowerService, D_BorrowerService>();
    /// </summary>
	public class D_BorrowerService : PbServiceBase<D_Borrower>, ID_BorrowerService
	{
		public D_BorrowerService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Borrower>> RetrieveAsync(double? a_bor_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Borrower>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_bor_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}