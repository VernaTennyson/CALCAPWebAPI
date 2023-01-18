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
    /// services.AddScoped<IDw_Lea_Loan_App_Lender_BorrowerService, Dw_Lea_Loan_App_Lender_BorrowerService>();
    /// </summary>
	public class Dw_Lea_Loan_App_Lender_BorrowerService : PbServiceBase<Dw_Lea_Loan_App_Lender_Borrower>, IDw_Lea_Loan_App_Lender_BorrowerService
	{
		public Dw_Lea_Loan_App_Lender_BorrowerService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<Dw_Lea_Loan_App_Lender_Borrower>> RetrieveAsync(double? a_f_lenderid, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Dw_Lea_Loan_App_Lender_Borrower>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_f_lenderid }, cancellationToken);
		 
			return dataStore;
		}	
    }
}