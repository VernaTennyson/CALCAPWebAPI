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
	public interface ID_Loan_Detail_OrigService : IPbServiceBase<D_Loan_Detail_Orig>
	{	
		Task<IDataStore<D_Loan_Detail_Orig>> RetrieveAsync(CancellationToken cancellationToken);
    }
}