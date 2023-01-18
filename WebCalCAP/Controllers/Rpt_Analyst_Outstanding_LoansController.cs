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
	public class Rpt_Analyst_Outstanding_LoansController : ControllerBase
	{
		private readonly IRpt_Analyst_Outstanding_LoansService _irpt_analyst_outstanding_loansservice;

		public Rpt_Analyst_Outstanding_LoansController(IRpt_Analyst_Outstanding_LoansService irpt_analyst_outstanding_loansservice)
		{
			_irpt_analyst_outstanding_loansservice = irpt_analyst_outstanding_loansservice;
		}

		//GET api/Rpt_Analyst_Outstanding_Loans/Retrieve/{a_analyst_assigned}
		[HttpGet("{a_analyst_assigned}")]
		[ProducesResponseType(typeof(IDataStore<Rpt_Analyst_Outstanding_Loans>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Rpt_Analyst_Outstanding_Loans>>> RetrieveAsync(double? a_analyst_assigned)
		{
			try
			{
				var result = await _irpt_analyst_outstanding_loansservice.RetrieveAsync(a_analyst_assigned, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
