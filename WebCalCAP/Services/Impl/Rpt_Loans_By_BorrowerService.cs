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
    /// services.AddScoped<IRpt_Loans_By_BorrowerService, Rpt_Loans_By_BorrowerService>();
    /// </summary>
	public class Rpt_Loans_By_BorrowerService : IRpt_Loans_By_BorrowerService
	{
		private readonly DataContext _dataContext;
			
		public Rpt_Loans_By_BorrowerService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<Rpt_Loans_By_Borrower>> RetrieveAsync(string a_bor_name, string a_bor_dba, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Rpt_Loans_By_Borrower>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_bor_name, a_bor_dba }, cancellationToken);
		 
			return dataStore;
		}	
    }
}