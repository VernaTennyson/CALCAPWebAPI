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
    /// services.AddScoped<ID_LenderService, D_LenderService>();
    /// </summary>
	public class D_LenderService : PbServiceBase<D_Lender>, ID_LenderService
	{
		public D_LenderService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Lender>> RetrieveAsync(double? a_len_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Lender>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_len_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}