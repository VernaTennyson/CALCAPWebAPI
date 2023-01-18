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
	public interface IDw_Lea_Loan_App_LoanService : IPbServiceBase<Dw_Lea_Loan_App_Loan>
	{	
		Task<IDataStore<Dw_Lea_Loan_App_Loan>> RetrieveAsync(decimal? a_f_lenderId, CancellationToken cancellationToken);
    }
}