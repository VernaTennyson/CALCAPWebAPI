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
	public interface IDddw_Year_Drop_DownService
	{	
		Task<IDataStore<Dddw_Year_Drop_Down>> RetrieveAsync(CancellationToken cancellationToken);
    }
}