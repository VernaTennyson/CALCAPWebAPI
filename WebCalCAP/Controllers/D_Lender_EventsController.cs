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
	public class D_Lender_EventsController : ControllerBase
	{
		private readonly ID_Lender_EventsService _id_lender_eventsservice;

		public D_Lender_EventsController(ID_Lender_EventsService id_lender_eventsservice)
		{
			_id_lender_eventsservice = id_lender_eventsservice;
		}

		//POST api/D_Lender_Events/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Lender_Events> dataStore)
		{
			try
			{
				var result = await _id_lender_eventsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Lender_Events/Retrieve/{a_len_id}
		[HttpGet("{a_len_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Lender_Events>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Lender_Events>>> RetrieveAsync(double? a_len_id)
		{
			try
			{
				var result = await _id_lender_eventsservice.RetrieveAsync(a_len_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
