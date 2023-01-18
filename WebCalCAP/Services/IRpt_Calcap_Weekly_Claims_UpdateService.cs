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
	public interface IRpt_Calcap_Weekly_Claims_UpdateService
	{	
		Task<IDataStore<Rpt_Calcap_Weekly_Claims_Update>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, string pending, CancellationToken cancellationToken);
    }
}