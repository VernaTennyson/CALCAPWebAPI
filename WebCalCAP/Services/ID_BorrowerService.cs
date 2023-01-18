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
	public interface ID_BorrowerService : IPbServiceBase<D_Borrower>
	{	
		Task<IDataStore<D_Borrower>> RetrieveAsync(double? a_bor_id, CancellationToken cancellationToken);
    }
}