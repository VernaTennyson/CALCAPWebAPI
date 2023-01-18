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
    /// services.AddScoped<ID_Calcapweb_Arb_Details2Service, D_Calcapweb_Arb_Details2Service>();
    /// </summary>
	public class D_Calcapweb_Arb_Details2Service : PbServiceBase<D_Calcapweb_Arb_Details2>, ID_Calcapweb_Arb_Details2Service
	{
		public D_Calcapweb_Arb_Details2Service(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Calcapweb_Arb_Details2>> RetrieveAsync(double? a_arb_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Calcapweb_Arb_Details2>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_arb_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}