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
	public class Dddw_Csp_Payment_ReasonController : ControllerBase
	{
		private readonly IDddw_Csp_Payment_ReasonService _idddw_csp_payment_reasonservice;

		public Dddw_Csp_Payment_ReasonController(IDddw_Csp_Payment_ReasonService idddw_csp_payment_reasonservice)
		{
			_idddw_csp_payment_reasonservice = idddw_csp_payment_reasonservice;
		}

		//GET api/Dddw_Csp_Payment_Reason/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Csp_Payment_Reason>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Csp_Payment_Reason>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_csp_payment_reasonservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
