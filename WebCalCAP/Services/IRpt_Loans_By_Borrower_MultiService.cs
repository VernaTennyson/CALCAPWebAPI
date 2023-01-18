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
	public interface IRpt_Loans_By_Borrower_MultiService
	{	
		Task<IDataStore<Rpt_Loans_By_Borrower_Multi>> RetrieveAsync(String[] a_bor_name, String[] a_bor_dba, CancellationToken cancellationToken);
    }
}