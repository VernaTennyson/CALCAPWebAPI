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
	public interface ID_Arb_OrigService : IPbServiceBase<D_Arb_Orig>
	{	
		Task<IDataStore<D_Arb_Orig>> RetrieveAsync(double? loa_id, CancellationToken cancellationToken);
    }
}