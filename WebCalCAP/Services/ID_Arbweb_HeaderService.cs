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
	public interface ID_Arbweb_HeaderService : IPbServiceBase<D_Arbweb_Header>
	{	
		Task<IDataStore<D_Arbweb_Header>> RetrieveAsync(CancellationToken cancellationToken);
    }
}