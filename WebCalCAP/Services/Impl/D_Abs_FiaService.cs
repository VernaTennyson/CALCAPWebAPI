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
    /// services.AddScoped<ID_Abs_FiaService, D_Abs_FiaService>();
    /// </summary>
	public class D_Abs_FiaService : PbServiceBase<D_Abs_Fia>, ID_Abs_FiaService
	{
		public D_Abs_FiaService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Fia>> RetrieveAsync(string a_lender_number, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Fia>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_lender_number }, cancellationToken);
		 
			return dataStore;
		}	
    }
}