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
	public interface ID_Calcapweb_Fia_SearchService : IPbServiceBase<D_Calcapweb_Fia_Search>
	{	
		Task<IDataStore<D_Calcapweb_Fia_Search>> RetrieveAsync(CancellationToken cancellationToken);
    }
}