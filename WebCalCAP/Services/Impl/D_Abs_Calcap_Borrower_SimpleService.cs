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
    /// services.AddScoped<ID_Abs_Calcap_Borrower_SimpleService, D_Abs_Calcap_Borrower_SimpleService>();
    /// </summary>
	public class D_Abs_Calcap_Borrower_SimpleService : PbServiceBase<D_Abs_Calcap_Borrower_Simple>, ID_Abs_Calcap_Borrower_SimpleService
	{
		public D_Abs_Calcap_Borrower_SimpleService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Calcap_Borrower_Simple>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Calcap_Borrower_Simple>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}