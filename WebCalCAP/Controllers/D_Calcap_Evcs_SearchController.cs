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
	public class D_Calcap_Evcs_SearchController : ControllerBase
	{
		private readonly ID_Calcap_Evcs_SearchService _id_calcap_evcs_searchservice;

		public D_Calcap_Evcs_SearchController(ID_Calcap_Evcs_SearchService id_calcap_evcs_searchservice)
		{
			_id_calcap_evcs_searchservice = id_calcap_evcs_searchservice;
		}

		//GET api/D_Calcap_Evcs_Search/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Calcap_Evcs_Search>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcap_Evcs_Search>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_calcap_evcs_searchservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
