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
	public interface ID_Abs_Evc_RebateService : IPbServiceBase<D_Abs_Evc_Rebate>
	{	
		Task<IDataStore<D_Abs_Evc_Rebate>> RetrieveAsync(double? a_evc, CancellationToken cancellationToken);
    }
}