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
	public interface ID_Abs_FiaService : IPbServiceBase<D_Abs_Fia>
	{	
		Task<IDataStore<D_Abs_Fia>> RetrieveAsync(string a_lender_number, CancellationToken cancellationToken);
    }
}