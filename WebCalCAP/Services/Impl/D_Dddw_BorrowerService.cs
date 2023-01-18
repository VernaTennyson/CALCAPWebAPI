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
    /// services.AddScoped<ID_Dddw_BorrowerService, D_Dddw_BorrowerService>();
    /// </summary>
	public class D_Dddw_BorrowerService : PbServiceBase<D_Dddw_Borrower>, ID_Dddw_BorrowerService
	{
		public D_Dddw_BorrowerService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Dddw_Borrower>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Dddw_Borrower>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}