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
	public interface ID_Abs_Lender_PickService : IPbServiceBase<D_Abs_Lender_Pick>
	{	
		Task<IDataStore<D_Abs_Lender_Pick>> RetrieveAsync(string a_len, CancellationToken cancellationToken);
    }
}