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
	public class D_Calcap_Arb_SearchController : ControllerBase
	{
		private readonly ID_Calcap_Arb_SearchService _id_calcap_arb_searchservice;

		public D_Calcap_Arb_SearchController(ID_Calcap_Arb_SearchService id_calcap_arb_searchservice)
		{
			_id_calcap_arb_searchservice = id_calcap_arb_searchservice;
		}

		//GET api/D_Calcap_Arb_Search/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Calcap_Arb_Search>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcap_Arb_Search>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_calcap_arb_searchservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
