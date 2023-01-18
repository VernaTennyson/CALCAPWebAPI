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
	public interface ID_Get_Roles_SqlserverService
	{	
		Task<IDataStore<D_Get_Roles_Sqlserver>> RetrieveAsync(CancellationToken cancellationToken);
    }
}