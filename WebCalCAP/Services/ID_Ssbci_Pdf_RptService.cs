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
	public interface ID_Ssbci_Pdf_RptService
	{	
		Task<IDataStore<D_Ssbci_Pdf_Rpt>> RetrieveAsync(double? a_id, CancellationToken cancellationToken);
    }
}