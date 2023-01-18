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
	public interface ID_Arb_Rpt_OrigService
	{	
		Task<IDataStore<D_Arb_Rpt_Orig>> RetrieveAsync(double? a_arb_id, CancellationToken cancellationToken);
    }
}