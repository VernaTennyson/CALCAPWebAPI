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
	public interface IDddw_Event_ManagerService
	{	
		Task<IDataStore<Dddw_Event_Manager>> RetrieveAsync(CancellationToken cancellationToken);
    }
}