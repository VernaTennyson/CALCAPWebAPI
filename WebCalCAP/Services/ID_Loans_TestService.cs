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
	public interface ID_Loans_TestService : IPbServiceBase<D_Loans_Test>
	{	
		Task<IDataStore<D_Loans_Test>> RetrieveAsync(CancellationToken cancellationToken);
    }
}