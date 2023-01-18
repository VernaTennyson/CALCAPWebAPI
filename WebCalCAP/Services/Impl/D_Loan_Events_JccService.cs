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
    /// services.AddScoped<ID_Loan_Events_JccService, D_Loan_Events_JccService>();
    /// </summary>
	public class D_Loan_Events_JccService : PbServiceBase<D_Loan_Events_Jcc>, ID_Loan_Events_JccService
	{
		public D_Loan_Events_JccService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Loan_Events_Jcc>> RetrieveAsync(double? a_loa_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Loan_Events_Jcc>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_loa_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}