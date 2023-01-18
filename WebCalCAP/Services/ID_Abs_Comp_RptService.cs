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
	public interface ID_Abs_Comp_RptService
	{	
		Task<IDataStore<D_Abs_Comp_Rpt>> RetrieveAsync(DateTime? a_date, CancellationToken cancellationToken);
    }
}