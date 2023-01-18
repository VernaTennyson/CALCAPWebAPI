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
	public interface ID_Abs_Calcap_Purpose_LoanService
	{	
		Task<IDataStore<D_Abs_Calcap_Purpose_Loan>> RetrieveAsync(CancellationToken cancellationToken);
    }
}