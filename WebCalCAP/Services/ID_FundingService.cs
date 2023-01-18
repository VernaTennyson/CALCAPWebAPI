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
	public interface ID_FundingService : IPbServiceBase<D_Funding>
	{	
		Task<IDataStore<D_Funding>> RetrieveAsync(double? a_loa_id, CancellationToken cancellationToken);
    }
}