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
    /// services.AddScoped<IDw_Dmz_LoanService, Dw_Dmz_LoanService>();
    /// </summary>
	public class Dw_Dmz_LoanService : PbServiceBase<Dw_Dmz_Loan>, IDw_Dmz_LoanService
	{
		public Dw_Dmz_LoanService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<Dw_Dmz_Loan>> RetrieveAsync(double? a_f_lenderid, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Dw_Dmz_Loan>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_f_lenderid }, cancellationToken);
		 
			return dataStore;
		}	
    }
}