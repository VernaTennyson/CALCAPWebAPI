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
    /// services.AddScoped<IDw_Lea_Loan_App_LoanService, Dw_Lea_Loan_App_LoanService>();
    /// </summary>
	public class Dw_Lea_Loan_App_LoanService : PbServiceBase<Dw_Lea_Loan_App_Loan>, IDw_Lea_Loan_App_LoanService
	{
		public Dw_Lea_Loan_App_LoanService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<Dw_Lea_Loan_App_Loan>> RetrieveAsync(decimal? a_f_lenderId, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Dw_Lea_Loan_App_Loan>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_f_lenderId }, cancellationToken);
		 
			return dataStore;
		}	
    }
}