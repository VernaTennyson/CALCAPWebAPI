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
	public class D_Abs_Reb_EventsController : ControllerBase
	{
		private readonly ID_Abs_Reb_EventsService _id_abs_reb_eventsservice;

		public D_Abs_Reb_EventsController(ID_Abs_Reb_EventsService id_abs_reb_eventsservice)
		{
			_id_abs_reb_eventsservice = id_abs_reb_eventsservice;
		}

		//POST api/D_Abs_Reb_Events/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Reb_Events> dataStore)
		{
			try
			{
				var result = await _id_abs_reb_eventsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Reb_Events/Retrieve/{a_cla_id}
		[HttpGet("{a_cla_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Reb_Events>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Reb_Events>>> RetrieveAsync(double? a_cla_id)
		{
			try
			{
				var result = await _id_abs_reb_eventsservice.RetrieveAsync(a_cla_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
