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
	public interface ID_Abs_Csp_PaymentsService : IPbServiceBase<D_Abs_Csp_Payments>
	{	
		Task<IDataStore<D_Abs_Csp_Payments>> RetrieveAsync(string p_type, double? p_csi_id, CancellationToken cancellationToken);
    }
}