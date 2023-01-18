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
	public interface ID_Lender_EventsService : IPbServiceBase<D_Lender_Events>
	{	
		Task<IDataStore<D_Lender_Events>> RetrieveAsync(double? a_len_id, CancellationToken cancellationToken);
    }
}