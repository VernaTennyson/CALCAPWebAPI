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
    /// services.AddScoped<ID_Abs_Fund_AdjustmentService, D_Abs_Fund_AdjustmentService>();
    /// </summary>
	public class D_Abs_Fund_AdjustmentService : PbServiceBase<D_Abs_Fund_Adjustment>, ID_Abs_Fund_AdjustmentService
	{
		public D_Abs_Fund_AdjustmentService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Fund_Adjustment>> RetrieveAsync(double? p_loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Fund_Adjustment>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { p_loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}