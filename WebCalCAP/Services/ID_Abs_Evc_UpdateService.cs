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
	public interface ID_Abs_Evc_UpdateService
	{	
		Task<IDataStore<D_Abs_Evc_Update>> RetrieveAsync(double? a_loa_id, CancellationToken cancellationToken);
    }
}