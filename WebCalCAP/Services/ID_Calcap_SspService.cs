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
	public interface ID_Calcap_SspService : IPbServiceBase<D_Calcap_Ssp>
	{	
		Task<IDataStore<D_Calcap_Ssp>> RetrieveAsync(double? a_ssp_id, CancellationToken cancellationToken);
    }
}