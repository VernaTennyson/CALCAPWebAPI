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
	public interface ID_Abs_Evcs_Supplemental_UpdateService : IPbServiceBase<D_Abs_Evcs_Supplemental_Update>
	{	
		Task<IDataStore<D_Abs_Evcs_Supplemental_Update>> RetrieveAsync(double? a_evc_id, CancellationToken cancellationToken);
    }
}