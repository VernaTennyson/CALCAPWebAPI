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
	public interface ID_Loan_Events_JccService : IPbServiceBase<D_Loan_Events_Jcc>
	{	
		Task<IDataStore<D_Loan_Events_Jcc>> RetrieveAsync(double? a_loa_id, CancellationToken cancellationToken);
    }
}