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
	public interface ID_ClaimsService : IPbServiceBase<D_Claims>
	{	
		Task<IDataStore<D_Claims>> RetrieveAsync(double? loa_id, CancellationToken cancellationToken);
    }
}