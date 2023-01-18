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
	public interface ID_Abs_CommentsService : IPbServiceBase<D_Abs_Comments>
	{	
		Task<IDataStore<D_Abs_Comments>> RetrieveAsync(double? p_loa_id, string p_type, CancellationToken cancellationToken);
    }
}