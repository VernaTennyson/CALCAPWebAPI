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
    /// services.AddScoped<ID_Lender_Funding_SourcesService, D_Lender_Funding_SourcesService>();
    /// </summary>
	public class D_Lender_Funding_SourcesService : PbServiceBase<D_Lender_Funding_Sources>, ID_Lender_Funding_SourcesService
	{
		public D_Lender_Funding_SourcesService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Lender_Funding_Sources>> RetrieveAsync(double? a_len_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Lender_Funding_Sources>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_len_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}