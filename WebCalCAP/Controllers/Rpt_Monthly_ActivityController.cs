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
	public class Rpt_Monthly_ActivityController : ControllerBase
	{
		private readonly IRpt_Monthly_ActivityService _irpt_monthly_activityservice;

		public Rpt_Monthly_ActivityController(IRpt_Monthly_ActivityService irpt_monthly_activityservice)
		{
			_irpt_monthly_activityservice = irpt_monthly_activityservice;
		}

		//GET api/Rpt_Monthly_Activity/Retrieve/{a_begin_dt}/{a_end_dt}
		[HttpGet("{a_begin_dt}/{a_end_dt}")]
		[ProducesResponseType(typeof(IDataStore<Rpt_Monthly_Activity>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Rpt_Monthly_Activity>>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt)
		{
			try
			{
				var result = await _irpt_monthly_activityservice.RetrieveAsync(a_begin_dt, a_end_dt, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
