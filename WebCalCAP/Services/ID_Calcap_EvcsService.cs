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
	public interface ID_Calcap_EvcsService : IPbServiceBase<D_Calcap_Evcs>
	{	
		Task<IDataStore<D_Calcap_Evcs>> RetrieveAsync(double? a_evcs_id, CancellationToken cancellationToken);
    }
}