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
	public interface IDddw_Lender_StatusService
	{	
		Task<IDataStore<Dddw_Lender_Status>> RetrieveAsync(CancellationToken cancellationToken);
    }
}