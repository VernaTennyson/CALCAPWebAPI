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
	public interface ID_Abs_Reb_EventsService : IPbServiceBase<D_Abs_Reb_Events>
	{	
		Task<IDataStore<D_Abs_Reb_Events>> RetrieveAsync(double? a_cla_id, CancellationToken cancellationToken);
    }
}