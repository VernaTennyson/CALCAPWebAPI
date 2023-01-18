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
	public interface IDddw_Employee_NamesService : IPbServiceBase<Dddw_Employee_Names>
	{	
		Task<IDataStore<Dddw_Employee_Names>> RetrieveAsync(CancellationToken cancellationToken);
    }
}