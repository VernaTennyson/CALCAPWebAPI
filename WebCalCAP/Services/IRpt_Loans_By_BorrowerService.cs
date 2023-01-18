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
	public interface IRpt_Loans_By_BorrowerService
	{	
		Task<IDataStore<Rpt_Loans_By_Borrower>> RetrieveAsync(string a_bor_name, string a_bor_dba, CancellationToken cancellationToken);
    }
}