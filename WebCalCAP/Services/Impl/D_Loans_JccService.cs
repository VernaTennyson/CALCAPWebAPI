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
    /// services.AddScoped<ID_Loans_JccService, D_Loans_JccService>();
    /// </summary>
	public class D_Loans_JccService : PbServiceBase<D_Loans_Jcc>, ID_Loans_JccService
	{
		public D_Loans_JccService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Loans_Jcc>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Loans_Jcc>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}