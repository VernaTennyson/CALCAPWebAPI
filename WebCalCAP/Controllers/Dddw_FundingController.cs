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
	public class Dddw_FundingController : ControllerBase
	{
		private readonly IDddw_FundingService _idddw_fundingservice;

		public Dddw_FundingController(IDddw_FundingService idddw_fundingservice)
		{
			_idddw_fundingservice = idddw_fundingservice;
		}

		//GET api/Dddw_Funding/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Funding>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Funding>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_fundingservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
