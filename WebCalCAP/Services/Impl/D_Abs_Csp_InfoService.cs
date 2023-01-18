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
    /// services.AddScoped<ID_Abs_Csp_InfoService, D_Abs_Csp_InfoService>();
    /// </summary>
	public class D_Abs_Csp_InfoService : PbServiceBase<D_Abs_Csp_Info>, ID_Abs_Csp_InfoService
	{
		public D_Abs_Csp_InfoService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Csp_Info>> RetrieveAsync(double? p_loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Csp_Info>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { p_loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}