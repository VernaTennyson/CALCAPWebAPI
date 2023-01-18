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
    /// services.AddScoped<IDddw_LenderService, Dddw_LenderService>();
    /// </summary>
	public class Dddw_LenderService : PbServiceBase<Dddw_Lender>, IDddw_LenderService
	{
		public Dddw_LenderService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<Dddw_Lender>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Dddw_Lender>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}