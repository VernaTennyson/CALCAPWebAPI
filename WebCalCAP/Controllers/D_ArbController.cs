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
	public class D_ArbController : ControllerBase
	{
		private readonly ID_ArbService _id_arbservice;

		public D_ArbController(ID_ArbService id_arbservice)
		{
			_id_arbservice = id_arbservice;
		}

		//POST api/D_Arb/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Arb> dataStore)
		{
			try
			{
				var result = await _id_arbservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Arb/Retrieve/{loa_id}
		[HttpGet("{loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Arb>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Arb>>> RetrieveAsync(double? loa_id)
		{
			try
			{
				var result = await _id_arbservice.RetrieveAsync(loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
