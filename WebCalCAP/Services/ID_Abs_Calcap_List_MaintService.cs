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
	public interface ID_Abs_Calcap_List_MaintService : IPbServiceBase<D_Abs_Calcap_List_Maint>
	{	
		Task<IDataStore<D_Abs_Calcap_List_Maint>> RetrieveAsync(string a_domain, CancellationToken cancellationToken);
    }
}