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
    /// services.AddScoped<ID_Loan_EventsService, D_Loan_EventsService>();
    /// </summary>
	public class D_Loan_EventsService : PbServiceBase<D_Loan_Events>, ID_Loan_EventsService
	{
		public D_Loan_EventsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Loan_Events>> RetrieveAsync(double? a_loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Loan_Events>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}