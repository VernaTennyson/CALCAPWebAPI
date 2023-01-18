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
	public interface ID_Calcap_CspService : IPbServiceBase<D_Calcap_Csp>
	{	
		Task<IDataStore<D_Calcap_Csp>> RetrieveAsync(double? a_sup_id, CancellationToken cancellationToken);
    }
}