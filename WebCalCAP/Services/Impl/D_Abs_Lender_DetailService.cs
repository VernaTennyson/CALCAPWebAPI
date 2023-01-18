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
    /// services.AddScoped<ID_Abs_Lender_DetailService, D_Abs_Lender_DetailService>();
    /// </summary>
	public class D_Abs_Lender_DetailService : PbServiceBase<D_Abs_Lender_Detail>, ID_Abs_Lender_DetailService
	{
		public D_Abs_Lender_DetailService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Lender_Detail>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Lender_Detail>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}