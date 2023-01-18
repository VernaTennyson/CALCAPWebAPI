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
    /// services.AddScoped<ID_Abs_Lender_ReportingService, D_Abs_Lender_ReportingService>();
    /// </summary>
	public class D_Abs_Lender_ReportingService : PbServiceBase<D_Abs_Lender_Reporting>, ID_Abs_Lender_ReportingService
	{
		public D_Abs_Lender_ReportingService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Lender_Reporting>> RetrieveAsync(double? a_len_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Lender_Reporting>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_len_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}