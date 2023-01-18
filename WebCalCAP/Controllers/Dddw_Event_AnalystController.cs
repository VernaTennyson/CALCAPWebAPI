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
	public class Dddw_Event_AnalystController : ControllerBase
	{
		private readonly IDddw_Event_AnalystService _idddw_event_analystservice;

		public Dddw_Event_AnalystController(IDddw_Event_AnalystService idddw_event_analystservice)
		{
			_idddw_event_analystservice = idddw_event_analystservice;
		}

		//GET api/Dddw_Event_Analyst/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Event_Analyst>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Event_Analyst>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_event_analystservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
