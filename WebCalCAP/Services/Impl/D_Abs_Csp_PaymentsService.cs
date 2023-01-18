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
    /// services.AddScoped<ID_Abs_Csp_PaymentsService, D_Abs_Csp_PaymentsService>();
    /// </summary>
	public class D_Abs_Csp_PaymentsService : PbServiceBase<D_Abs_Csp_Payments>, ID_Abs_Csp_PaymentsService
	{
		public D_Abs_Csp_PaymentsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Csp_Payments>> RetrieveAsync(string p_type, double? p_csi_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Csp_Payments>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { p_type, p_csi_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}