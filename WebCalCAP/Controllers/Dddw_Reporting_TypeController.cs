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
	public class Dddw_Reporting_TypeController : ControllerBase
	{
		private readonly IDddw_Reporting_TypeService _idddw_reporting_typeservice;

		public Dddw_Reporting_TypeController(IDddw_Reporting_TypeService idddw_reporting_typeservice)
		{
			_idddw_reporting_typeservice = idddw_reporting_typeservice;
		}

		//GET api/Dddw_Reporting_Type/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Reporting_Type>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Reporting_Type>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_reporting_typeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
