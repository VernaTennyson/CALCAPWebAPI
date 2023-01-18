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
	public class D_Claim_EventsController : ControllerBase
	{
		private readonly ID_Claim_EventsService _id_claim_eventsservice;

		public D_Claim_EventsController(ID_Claim_EventsService id_claim_eventsservice)
		{
			_id_claim_eventsservice = id_claim_eventsservice;
		}

		//POST api/D_Claim_Events/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Claim_Events> dataStore)
		{
			try
			{
				var result = await _id_claim_eventsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Claim_Events/Retrieve/{a_cla_id}
		[HttpGet("{a_cla_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Claim_Events>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Claim_Events>>> RetrieveAsync(double? a_cla_id)
		{
			try
			{
				var result = await _id_claim_eventsservice.RetrieveAsync(a_cla_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
