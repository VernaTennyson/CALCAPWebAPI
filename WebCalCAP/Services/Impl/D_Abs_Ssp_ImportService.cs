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
    /// services.AddScoped<ID_Abs_Ssp_ImportService, D_Abs_Ssp_ImportService>();
    /// </summary>
	public class D_Abs_Ssp_ImportService : PbServiceBase<D_Abs_Ssp_Import>, ID_Abs_Ssp_ImportService
	{
		public D_Abs_Ssp_ImportService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Ssp_Import>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Ssp_Import>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}