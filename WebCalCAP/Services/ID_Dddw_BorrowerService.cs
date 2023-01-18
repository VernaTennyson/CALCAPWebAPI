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
	public interface ID_Dddw_BorrowerService : IPbServiceBase<D_Dddw_Borrower>
	{	
		Task<IDataStore<D_Dddw_Borrower>> RetrieveAsync(CancellationToken cancellationToken);
    }
}