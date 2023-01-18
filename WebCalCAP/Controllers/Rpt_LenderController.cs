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
	public class Rpt_LenderController : ControllerBase
	{
		private readonly IRpt_LenderService _irpt_lenderservice;

		public Rpt_LenderController(IRpt_LenderService irpt_lenderservice)
		{
			_irpt_lenderservice = irpt_lenderservice;
		}

		//GET api/Rpt_Lender/Retrieve/{a_begin_dt}/{a_end_dt}/{a_len_id}
		[HttpGet("{a_begin_dt}/{a_end_dt}/{a_len_id}")]
		[ProducesResponseType(typeof(IDataStore<Rpt_Lender>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Rpt_Lender>>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt, double? a_len_id)
		{
			try
			{
				var result = await _irpt_lenderservice.RetrieveAsync(a_begin_dt, a_end_dt, a_len_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
