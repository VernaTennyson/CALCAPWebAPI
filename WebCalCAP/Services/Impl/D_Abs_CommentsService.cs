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
    /// services.AddScoped<ID_Abs_CommentsService, D_Abs_CommentsService>();
    /// </summary>
	public class D_Abs_CommentsService : PbServiceBase<D_Abs_Comments>, ID_Abs_CommentsService
	{
		public D_Abs_CommentsService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Comments>> RetrieveAsync(double? p_loa_id, string p_type, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Comments>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { p_loa_id, p_type }, cancellationToken);
		 
			return dataStore;
		}	
    }
}