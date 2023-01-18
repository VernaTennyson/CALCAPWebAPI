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
    /// services.AddScoped<ID_Abs_Evc_UpdateService, D_Abs_Evc_UpdateService>();
    /// </summary>
	public class D_Abs_Evc_UpdateService : ID_Abs_Evc_UpdateService
	{
		private readonly DataContext _dataContext;
			
		public D_Abs_Evc_UpdateService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Abs_Evc_Update>> RetrieveAsync(double? a_loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Evc_Update>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}