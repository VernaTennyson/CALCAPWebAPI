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
    /// services.AddScoped<ID_Ssbci_Pdf_RptService, D_Ssbci_Pdf_RptService>();
    /// </summary>
	public class D_Ssbci_Pdf_RptService : ID_Ssbci_Pdf_RptService
	{
		private readonly DataContext _dataContext;
			
		public D_Ssbci_Pdf_RptService(CalCAPDataContext dataContext)
		{
			_dataContext = dataContext;
		}	
		
		public async Task<IDataStore<D_Ssbci_Pdf_Rpt>> RetrieveAsync(double? a_id, CancellationToken cancellationToken)
		{
			var dataStore = new DataStore<D_Ssbci_Pdf_Rpt>(_dataContext);
		
			await dataStore.RetrieveAsync(new object[] { a_id }, cancellationToken);
		 
			return dataStore;
		}	
    }
}