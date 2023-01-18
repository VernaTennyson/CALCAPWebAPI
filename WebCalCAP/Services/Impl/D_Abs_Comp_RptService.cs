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
    /// services.AddScoped<ID_Abs_Comp_RptService, D_Abs_Comp_RptService>();
    /// </summary>
	public class D_Abs_Comp_RptService : ID_Abs_Comp_RptService
	{
		private readonly DataContext _dataContext;
			
		public D_Abs_Comp_RptService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Abs_Comp_Rpt>> RetrieveAsync(DateTime? a_date, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Comp_Rpt>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_date }, cancellationToken);
		 
			return dataStore;
		}	
    }
}