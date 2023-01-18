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
    /// services.AddScoped<ID_Abs_Borrower_Dba_PickService, D_Abs_Borrower_Dba_PickService>();
    /// </summary>
	public class D_Abs_Borrower_Dba_PickService : ID_Abs_Borrower_Dba_PickService
	{
		private readonly DataContext _dataContext;
			
		public D_Abs_Borrower_Dba_PickService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Abs_Borrower_Dba_Pick>> RetrieveAsync(string a_bor, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Borrower_Dba_Pick>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_bor }, cancellationToken);
		 
			return dataStore;
		}	
    }
}