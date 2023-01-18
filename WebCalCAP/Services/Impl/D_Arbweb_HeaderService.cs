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
    /// services.AddScoped<ID_Arbweb_HeaderService, D_Arbweb_HeaderService>();
    /// </summary>
	public class D_Arbweb_HeaderService : PbServiceBase<D_Arbweb_Header>, ID_Arbweb_HeaderService
	{
		public D_Arbweb_HeaderService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Arbweb_Header>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Arbweb_Header>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}