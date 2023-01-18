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
	public class Dddw_Event_AdminController : ControllerBase
	{
		private readonly IDddw_Event_AdminService _idddw_event_adminservice;

		public Dddw_Event_AdminController(IDddw_Event_AdminService idddw_event_adminservice)
		{
			_idddw_event_adminservice = idddw_event_adminservice;
		}

		//GET api/Dddw_Event_Admin/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Event_Admin>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Event_Admin>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_event_adminservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
