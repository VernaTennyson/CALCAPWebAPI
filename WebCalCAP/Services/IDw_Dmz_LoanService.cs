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
	public interface IDw_Dmz_LoanService : IPbServiceBase<Dw_Dmz_Loan>
	{	
		Task<IDataStore<Dw_Dmz_Loan>> RetrieveAsync(double? a_f_lenderid, CancellationToken cancellationToken);
    }
}