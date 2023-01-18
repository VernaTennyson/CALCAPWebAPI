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
	public interface ID_Calcap_Lea_Loan_ImportService : IPbServiceBase<D_Calcap_Lea_Loan_Import>
	{	
		Task<IDataStore<D_Calcap_Lea_Loan_Import>> RetrieveAsync(CancellationToken cancellationToken);
    }
}