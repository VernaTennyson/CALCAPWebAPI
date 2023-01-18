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
    /// services.AddScoped<ID_Abs_Loan_Sql_ConvService, D_Abs_Loan_Sql_ConvService>();
    /// </summary>
	public class D_Abs_Loan_Sql_ConvService : PbServiceBase<D_Abs_Loan_Sql_Conv>, ID_Abs_Loan_Sql_ConvService
	{
		public D_Abs_Loan_Sql_ConvService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<D_Abs_Loan_Sql_Conv>> RetrieveAsync(CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Abs_Loan_Sql_Conv>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { }, cancellationToken);
		 
			return dataStore;
		}	
    }
}