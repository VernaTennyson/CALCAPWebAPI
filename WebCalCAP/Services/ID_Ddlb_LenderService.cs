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
	public interface ID_Ddlb_LenderService : IPbServiceBase<D_Ddlb_Lender>
	{	
		Task<IDataStore<D_Ddlb_Lender>> RetrieveAsync(CancellationToken cancellationToken);
    }
}