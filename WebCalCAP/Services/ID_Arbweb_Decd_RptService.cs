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
	public interface ID_Arbweb_Decd_RptService : IPbServiceBase<D_Arbweb_Decd_Rpt>
	{	
		Task<IDataStore<D_Arbweb_Decd_Rpt>> RetrieveAsync(double? a_arb_id, CancellationToken cancellationToken);
    }
}