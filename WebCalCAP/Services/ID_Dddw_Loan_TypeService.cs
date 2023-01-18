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
	public interface ID_Dddw_Loan_TypeService
	{	
		Task<IDataStore<D_Dddw_Loan_Type>> RetrieveAsync(CancellationToken cancellationToken);
    }
}