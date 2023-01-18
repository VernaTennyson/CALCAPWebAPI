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
    /// services.AddScoped<ID_Abs_Evcs_Supplemental_UpdateService, D_Abs_Evcs_Supplemental_UpdateService>();
    /// </summary>
	public class D_Abs_Evcs_Supplemental_UpdateService : PbServiceBase<D_Abs_Evcs_Supplemental_Update>, ID_Abs_Evcs_Supplemental_UpdateService
	{
		public D_Abs_Evcs_Supplemental_UpdateService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Evcs_Supplemental_Update>> RetrieveAsync(double? a_evc_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Evcs_Supplemental_Update>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_evc_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}