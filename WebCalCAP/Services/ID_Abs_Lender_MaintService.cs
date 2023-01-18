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
	public interface ID_Abs_Lender_MaintService : IPbServiceBase<D_Abs_Lender_Maint>
	{	
		Task<IDataStore<D_Abs_Lender_Maint>> RetrieveAsync(CancellationToken cancellationToken);
    }
}