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
	public interface ID_Abs_Lender_Maint_ListService : IPbServiceBase<D_Abs_Lender_Maint_List>
	{	
		Task<IDataStore<D_Abs_Lender_Maint_List>> RetrieveAsync(CancellationToken cancellationToken);
    }
}