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
	public interface IRpt_Monthly_ActivityService
	{	
		Task<IDataStore<Rpt_Monthly_Activity>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, CancellationToken cancellationToken);
    }
}