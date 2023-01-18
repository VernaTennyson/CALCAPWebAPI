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
	public interface ID_Abs_Ssp_ImportService : IPbServiceBase<D_Abs_Ssp_Import>
	{	
		Task<IDataStore<D_Abs_Ssp_Import>> RetrieveAsync(CancellationToken cancellationToken);
    }
}