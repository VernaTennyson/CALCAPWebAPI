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
	public interface IRpt_Calcap_Monthly_Claims_DetailService
	{	
		Task<IDataStore<Rpt_Calcap_Monthly_Claims_Detail>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, CancellationToken cancellationToken);
    }
}