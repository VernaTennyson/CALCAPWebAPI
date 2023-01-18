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
	public interface IDw_Fia_InstitutionService : IPbServiceBase<Dw_Fia_Institution>
	{	
		Task<IDataStore<Dw_Fia_Institution>> RetrieveAsync(double? a_f_fiaId, CancellationToken cancellationToken);
    }
}