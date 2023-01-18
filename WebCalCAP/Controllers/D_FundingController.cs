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
	public class D_FundingController : ControllerBase
	{
		private readonly ID_FundingService _id_fundingservice;

		public D_FundingController(ID_FundingService id_fundingservice)
		{
			_id_fundingservice = id_fundingservice;
		}

		//POST api/D_Funding/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Funding> dataStore)
		{
			try
			{
				var result = await _id_fundingservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Funding/Retrieve/{a_loa_id}
		[HttpGet("{a_loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Funding>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Funding>>> RetrieveAsync(double? a_loa_id)
		{
			try
			{
				var result = await _id_fundingservice.RetrieveAsync(a_loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
