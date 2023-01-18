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
	public interface IRpt_LenderService
	{	
		Task<IDataStore<Rpt_Lender>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, double? a_len_id, CancellationToken cancellationToken);
    }
}