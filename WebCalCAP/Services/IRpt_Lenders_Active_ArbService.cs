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
	public interface IRpt_Lenders_Active_ArbService
	{	
		Task<IDataStore<Rpt_Lenders_Active_Arb>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, string a_loan_program, CancellationToken cancellationToken);
    }
}