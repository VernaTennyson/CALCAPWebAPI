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
	public class Dddw_Event_StatusController : ControllerBase
	{
		private readonly IDddw_Event_StatusService _idddw_event_statusservice;

		public Dddw_Event_StatusController(IDddw_Event_StatusService idddw_event_statusservice)
		{
			_idddw_event_statusservice = idddw_event_statusservice;
		}

		//POST api/Dddw_Event_Status/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dddw_Event_Status> dataStore)
		{
			try
			{
				var result = await _idddw_event_statusservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dddw_Event_Status/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Event_Status>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Event_Status>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_event_statusservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
