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
	public class Dddw_Lender_FundingController : ControllerBase
	{
		private readonly IDddw_Lender_FundingService _idddw_lender_fundingservice;

		public Dddw_Lender_FundingController(IDddw_Lender_FundingService idddw_lender_fundingservice)
		{
			_idddw_lender_fundingservice = idddw_lender_fundingservice;
		}

		//GET api/Dddw_Lender_Funding/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Lender_Funding>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Lender_Funding>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_lender_fundingservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
