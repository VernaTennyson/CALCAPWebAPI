using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using SnapObjects.Data;
using DWNet.Data;
using WebCalCAP;
using WebCalCAP.Models;

namespace WebCalCAP.Services.Impl
{
    /// <summary>
	/// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<IRpt_Loans_By_Borrower_MultiService, Rpt_Loans_By_Borrower_MultiService>();
    /// </summary>
	public class Rpt_Loans_By_Borrower_MultiService : IRpt_Loans_By_Borrower_MultiService
	{
		private readonly DataContext _dataContext;
			
		public Rpt_Loans_By_Borrower_MultiService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Rpt_Loans_By_Borrower_Multi>> RetrieveAsync(String[] a_bor_name, String[] a_bor_dba, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Rpt_Loans_By_Borrower_Multi>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_bor_name, a_bor_dba }, cancellationToken);
		 
			return dataStore;
		}	
    }
}