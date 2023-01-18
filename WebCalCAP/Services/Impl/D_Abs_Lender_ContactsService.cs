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
    /// services.AddScoped<ID_Abs_Lender_ContactsService, D_Abs_Lender_ContactsService>();
    /// </summary>
	public class D_Abs_Lender_ContactsService : PbServiceBase<D_Abs_Lender_Contacts>, ID_Abs_Lender_ContactsService
	{
		public D_Abs_Lender_ContactsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Lender_Contacts>> RetrieveAsync(double? a_len_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Lender_Contacts>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_len_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}