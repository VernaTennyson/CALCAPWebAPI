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
	public interface IDddw_Sev_Aff_ComService
	{	
		Task<IDataStore<Dddw_Sev_Aff_Com>> RetrieveAsync(CancellationToken cancellationToken);
    }
}