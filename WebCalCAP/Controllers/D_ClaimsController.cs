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
	public class D_ClaimsController : ControllerBase
	{
		private readonly ID_ClaimsService _id_claimsservice;

		public D_ClaimsController(ID_ClaimsService id_claimsservice)
		{
			_id_claimsservice = id_claimsservice;
		}

		//POST api/D_Claims/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Claims> dataStore)
		{
			try
			{
				var result = await _id_claimsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Claims/Retrieve/{loa_id}
		[HttpGet("{loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Claims>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Claims>>> RetrieveAsync(double? loa_id)
		{
			try
			{
				var result = await _id_claimsservice.RetrieveAsync(loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
