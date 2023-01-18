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
	public class Rpt_Calcap_Monthly_Claims_DetailController : ControllerBase
	{
		private readonly IRpt_Calcap_Monthly_Claims_DetailService _irpt_calcap_monthly_claims_detailservice;

		public Rpt_Calcap_Monthly_Claims_DetailController(IRpt_Calcap_Monthly_Claims_DetailService irpt_calcap_monthly_claims_detailservice)
		{
			_irpt_calcap_monthly_claims_detailservice = irpt_calcap_monthly_claims_detailservice;
		}

		//GET api/Rpt_Calcap_Monthly_Claims_Detail/Retrieve/{a_begin_dt}/{a_end_dt}
		[HttpGet("{a_begin_dt}/{a_end_dt}")]
		[ProducesResponseType(typeof(IDataStore<Rpt_Calcap_Monthly_Claims_Detail>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Rpt_Calcap_Monthly_Claims_Detail>>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt)
		{
			try
			{
				var result = await _irpt_calcap_monthly_claims_detailservice.RetrieveAsync(a_begin_dt, a_end_dt, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
