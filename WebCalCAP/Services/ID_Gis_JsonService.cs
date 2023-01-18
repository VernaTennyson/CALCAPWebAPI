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
	public interface ID_Gis_JsonService
	{	
		Task<IDataStore<D_Gis_Json>> RetrieveAsync(CancellationToken cancellationToken);
    }
}