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
    /// services.AddScoped<ID_Abs_Calcap_List_MaintService, D_Abs_Calcap_List_MaintService>();
    /// </summary>
	public class D_Abs_Calcap_List_MaintService : PbServiceBase<D_Abs_Calcap_List_Maint>, ID_Abs_Calcap_List_MaintService
	{
		public D_Abs_Calcap_List_MaintService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Calcap_List_Maint>> RetrieveAsync(string a_domain, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Calcap_List_Maint>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_domain }, cancellationToken);
		 
			return dataStore;
		}	
    }
}