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
	public interface ID_Import_New_AccessService
	{	
		Task<IDataStore<D_Import_New_Access>> RetrieveAsync(CancellationToken cancellationToken);
    }
}