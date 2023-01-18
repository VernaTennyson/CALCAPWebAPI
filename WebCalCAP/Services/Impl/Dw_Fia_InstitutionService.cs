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
    /// services.AddScoped<IDw_Fia_InstitutionService, Dw_Fia_InstitutionService>();
    /// </summary>
	public class Dw_Fia_InstitutionService : PbServiceBase<Dw_Fia_Institution>, IDw_Fia_InstitutionService
	{
		public Dw_Fia_InstitutionService(CalCAPDataContext dataContext) : base(dataContext)
		{
				
		} 
		
		public async Task<IDataStore<Dw_Fia_Institution>> RetrieveAsync(double? a_f_fiaId, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<Dw_Fia_Institution>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_f_fiaId }, cancellationToken);
		 
			return dataStore;
		}	
    }
}