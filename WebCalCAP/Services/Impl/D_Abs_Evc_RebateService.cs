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
    /// services.AddScoped<ID_Abs_Evc_RebateService, D_Abs_Evc_RebateService>();
    /// </summary>
	public class D_Abs_Evc_RebateService : PbServiceBase<D_Abs_Evc_Rebate>, ID_Abs_Evc_RebateService
	{
		public D_Abs_Evc_RebateService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Evc_Rebate>> RetrieveAsync(double? a_evc, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Evc_Rebate>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_evc }, cancellationToken);
		 
			return dataStore;
		}	
    }
}