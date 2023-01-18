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
	public interface IDddw_Retro_Tech_TypeService
	{	
		Task<IDataStore<Dddw_Retro_Tech_Type>> RetrieveAsync(CancellationToken cancellationToken);
    }
}