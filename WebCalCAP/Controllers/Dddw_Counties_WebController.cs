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
	public class Dddw_Counties_WebController : ControllerBase
	{
		private readonly IDddw_Counties_WebService _idddw_counties_webservice;

		public Dddw_Counties_WebController(IDddw_Counties_WebService idddw_counties_webservice)
		{
			_idddw_counties_webservice = idddw_counties_webservice;
		}

		//GET api/Dddw_Counties_Web/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Counties_Web>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Counties_Web>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_counties_webservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
