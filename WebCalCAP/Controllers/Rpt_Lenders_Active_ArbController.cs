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
	public class Rpt_Lenders_Active_ArbController : ControllerBase
	{
		private readonly IRpt_Lenders_Active_ArbService _irpt_lenders_active_arbservice;

		public Rpt_Lenders_Active_ArbController(IRpt_Lenders_Active_ArbService irpt_lenders_active_arbservice)
		{
			_irpt_lenders_active_arbservice = irpt_lenders_active_arbservice;
		}

		//GET api/Rpt_Lenders_Active_Arb/Retrieve/{a_begin_dt}/{a_end_dt}/{a_loan_program}
		[HttpGet("{a_begin_dt}/{a_end_dt}/{a_loan_program}")]
		[ProducesResponseType(typeof(IDataStore<Rpt_Lenders_Active_Arb>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Rpt_Lenders_Active_Arb>>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, string a_loan_program)
		{
			try
			{
				var result = await _irpt_lenders_active_arbservice.RetrieveAsync(a_begin_dt, a_end_dt, a_loan_program, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
