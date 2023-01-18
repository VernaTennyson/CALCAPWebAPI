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
	public class Dddw_Lender_StatusController : ControllerBase
	{
		private readonly IDddw_Lender_StatusService _idddw_lender_statusservice;

		public Dddw_Lender_StatusController(IDddw_Lender_StatusService idddw_lender_statusservice)
		{
			_idddw_lender_statusservice = idddw_lender_statusservice;
		}

		//GET api/Dddw_Lender_Status/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Lender_Status>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Lender_Status>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_lender_statusservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
