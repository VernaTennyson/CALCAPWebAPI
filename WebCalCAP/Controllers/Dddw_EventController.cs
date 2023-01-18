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
	public class Dddw_EventController : ControllerBase
	{
		private readonly IDddw_EventService _idddw_eventservice;

		public Dddw_EventController(IDddw_EventService idddw_eventservice)
		{
			_idddw_eventservice = idddw_eventservice;
		}

		//GET api/Dddw_Event/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Event>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Event>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_eventservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
