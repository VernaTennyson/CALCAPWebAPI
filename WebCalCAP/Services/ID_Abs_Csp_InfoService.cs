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
	public interface ID_Abs_Csp_InfoService : IPbServiceBase<D_Abs_Csp_Info>
	{	
		Task<IDataStore<D_Abs_Csp_Info>> RetrieveAsync(double? p_loa_id, CancellationToken cancellationToken);
    }
}