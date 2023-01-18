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
	public interface IDddw_Arb_Fuel_TypeService
	{	
		Task<IDataStore<Dddw_Arb_Fuel_Type>> RetrieveAsync(CancellationToken cancellationToken);
    }
}