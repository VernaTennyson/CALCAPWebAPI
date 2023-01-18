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
    /// services.AddScoped<ID_Abs_Lender_PickService, D_Abs_Lender_PickService>();
    /// </summary>
	public class D_Abs_Lender_PickService : PbServiceBase<D_Abs_Lender_Pick>, ID_Abs_Lender_PickService
	{
		public D_Abs_Lender_PickService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Lender_Pick>> RetrieveAsync(string a_len, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Lender_Pick>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_len }, cancellationToken);
		 
			return dataStore;
		}	
    }
}