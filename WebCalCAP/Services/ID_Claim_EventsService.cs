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
	public interface ID_Claim_EventsService : IPbServiceBase<D_Claim_Events>
	{	
		Task<IDataStore<D_Claim_Events>> RetrieveAsync(double? a_cla_id, CancellationToken cancellationToken);
    }
}