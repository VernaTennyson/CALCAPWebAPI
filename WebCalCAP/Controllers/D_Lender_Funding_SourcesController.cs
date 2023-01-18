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
	public class D_Lender_Funding_SourcesController : ControllerBase
	{
		private readonly ID_Lender_Funding_SourcesService _id_lender_funding_sourcesservice;

		public D_Lender_Funding_SourcesController(ID_Lender_Funding_SourcesService id_lender_funding_sourcesservice)
		{
			_id_lender_funding_sourcesservice = id_lender_funding_sourcesservice;
		}

		//POST api/D_Lender_Funding_Sources/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Lender_Funding_Sources> dataStore)
		{
			try
			{
				var result = await _id_lender_funding_sourcesservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Lender_Funding_Sources/Retrieve/{a_len_id}
		[HttpGet("{a_len_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Lender_Funding_Sources>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Lender_Funding_Sources>>> RetrieveAsync(double? a_len_id)
		{
			try
			{
				var result = await _id_lender_funding_sourcesservice.RetrieveAsync(a_len_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
