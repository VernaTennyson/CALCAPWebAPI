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
    /// services.AddScoped<ID_Arb_Rpt_OrigService, D_Arb_Rpt_OrigService>();
    /// </summary>
	public class D_Arb_Rpt_OrigService : ID_Arb_Rpt_OrigService
	{
		private readonly DataContext _dataContext;
			
		public D_Arb_Rpt_OrigService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Arb_Rpt_Orig>> RetrieveAsync(double? a_arb_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Arb_Rpt_Orig>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_arb_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}