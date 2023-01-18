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
	public interface ID_Abs_Calcap_EnrollmentService : IPbServiceBase<D_Abs_Calcap_Enrollment>
	{	
		Task<IDataStore<D_Abs_Calcap_Enrollment>> RetrieveAsync(CancellationToken cancellationToken);
    }
}