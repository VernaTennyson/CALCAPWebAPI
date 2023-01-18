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
	public interface ID_Calcapweb_Arb_Details2Service : IPbServiceBase<D_Calcapweb_Arb_Details2>
	{	
		Task<IDataStore<D_Calcapweb_Arb_Details2>> RetrieveAsync(double? a_arb_id, CancellationToken cancellationToken);
    }
}