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
	public class Dddw_Event_ManagerController : ControllerBase
	{
		private readonly IDddw_Event_ManagerService _idddw_event_managerservice;

		public Dddw_Event_ManagerController(IDddw_Event_ManagerService idddw_event_managerservice)
		{
			_idddw_event_managerservice = idddw_event_managerservice;
		}

		//GET api/Dddw_Event_Manager/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Event_Manager>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Event_Manager>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_event_managerservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
