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
    /// services.AddScoped<ID_Ddlb_LenderService, D_Ddlb_LenderService>();
    /// </summary>
	public class D_Ddlb_LenderService : PbServiceBase<D_Ddlb_Lender>, ID_Ddlb_LenderService
	{
		public D_Ddlb_LenderService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Ddlb_Lender>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Ddlb_Lender>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}