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
    /// services.AddScoped<ID_Loans_TestService, D_Loans_TestService>();
    /// </summary>
	public class D_Loans_TestService : PbServiceBase<D_Loans_Test>, ID_Loans_TestService
	{
		public D_Loans_TestService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Loans_Test>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Loans_Test>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}