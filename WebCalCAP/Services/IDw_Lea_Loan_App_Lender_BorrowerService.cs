using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using SnapObjects.Data;
using DWNet.Data;
using WebCalCAP;
using WebCalCAP.Models;
	
namespace WebCalCAP.Services
{
	public interface IDw_Lea_Loan_App_Lender_BorrowerService : IPbServiceBase<Dw_Lea_Loan_App_Lender_Borrower>
	{	
		Task<IDataStore<Dw_Lea_Loan_App_Lender_Borrower>> RetrieveAsync(double? a_f_lenderid, CancellationToken cancellationToken);
    }
}