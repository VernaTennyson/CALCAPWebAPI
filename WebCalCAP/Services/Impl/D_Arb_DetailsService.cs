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
    /// services.AddScoped<ID_Arb_DetailsService, D_Arb_DetailsService>();
    /// </summary>
	public class D_Arb_DetailsService : ID_Arb_DetailsService
	{
		private readonly DataContext _dataContext;
			
		public D_Arb_DetailsService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Arb_Details>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Arb_Details>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}