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
	public class D_Arb_OrigController : ControllerBase
	{
		private readonly ID_Arb_OrigService _id_arb_origservice;

		public D_Arb_OrigController(ID_Arb_OrigService id_arb_origservice)
		{
			_id_arb_origservice = id_arb_origservice;
		}

		//POST api/D_Arb_Orig/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Arb_Orig> dataStore)
		{
			try
			{
				var result = await _id_arb_origservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Arb_Orig/Retrieve/{loa_id}
		[HttpGet("{loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Arb_Orig>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Arb_Orig>>> RetrieveAsync(double? loa_id)
		{
			try
			{
				var result = await _id_arb_origservice.RetrieveAsync(loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
