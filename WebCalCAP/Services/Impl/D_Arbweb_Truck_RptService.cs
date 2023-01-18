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
    /// services.AddScoped<ID_Arbweb_Truck_RptService, D_Arbweb_Truck_RptService>();
    /// </summary>
	public class D_Arbweb_Truck_RptService : ID_Arbweb_Truck_RptService
	{
		private readonly DataContext _dataContext;
			
		public D_Arbweb_Truck_RptService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Arbweb_Truck_Rpt>> RetrieveAsync(double? a_arb_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Arbweb_Truck_Rpt>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_arb_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}