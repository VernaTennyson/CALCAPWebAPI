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
	public interface IRpt_Analyst_Outstanding_LoansService
	{	
		Task<IDataStore<Rpt_Analyst_Outstanding_Loans>> RetrieveAsync(double? a_analyst_assigned, CancellationToken cancellationToken);
    }
}