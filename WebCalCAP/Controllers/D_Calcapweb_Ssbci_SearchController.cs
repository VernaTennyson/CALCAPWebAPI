using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Collections.Generic;
using DWNet.Data;
using WebCalCAP.Services;
using System.Threading.Tasks;
using System.Threading;
using WebCalCAP.Models;

namespace WebCalCAP.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class D_Calcapweb_Ssbci_SearchController : ControllerBase
	{
		private readonly ID_Calcapweb_Ssbci_SearchService _id_calcapweb_ssbci_searchservice;

		public D_Calcapweb_Ssbci_SearchController(ID_Calcapweb_Ssbci_SearchService id_calcapweb_ssbci_searchservice)
		{
			_id_calcapweb_ssbci_searchservice = id_calcapweb_ssbci_searchservice;
		}

		//GET api/D_Calcapweb_Ssbci_Search/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Calcapweb_Ssbci_Search>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcapweb_Ssbci_Search>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_calcapweb_ssbci_searchservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
