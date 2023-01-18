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
	public interface ID_Abs_Calcap_Borrower_SimpleService : IPbServiceBase<D_Abs_Calcap_Borrower_Simple>
	{	
		Task<IDataStore<D_Abs_Calcap_Borrower_Simple>> RetrieveAsync(CancellationToken cancellationToken);
    }
}