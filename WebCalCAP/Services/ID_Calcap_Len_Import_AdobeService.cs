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
	public interface ID_Calcap_Len_Import_AdobeService : IPbServiceBase<D_Calcap_Len_Import_Adobe>
	{	
		Task<IDataStore<D_Calcap_Len_Import_Adobe>> RetrieveAsync(CancellationToken cancellationToken);
    }
}