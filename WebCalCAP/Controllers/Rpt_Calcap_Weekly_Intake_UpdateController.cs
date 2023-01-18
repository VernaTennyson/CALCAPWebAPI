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
	public class Rpt_Calcap_Weekly_Intake_UpdateController : ControllerBase
	{
		private readonly IRpt_Calcap_Weekly_Intake_UpdateService _irpt_calcap_weekly_intake_updateservice;

		public Rpt_Calcap_Weekly_Intake_UpdateController(IRpt_Calcap_Weekly_Intake_UpdateService irpt_calcap_weekly_intake_updateservice)
		{
			_irpt_calcap_weekly_intake_updateservice = irpt_calcap_weekly_intake_updateservice;
		}

		//GET api/Rpt_Calcap_Weekly_Intake_Update/Retrieve/{a_begin_dt}/{a_end_dt}
		[HttpGet("{a_begin_dt}/{a_end_dt}")]
		[ProducesResponseType(typeof(IDataStore<Rpt_Calcap_Weekly_Intake_Update>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Rpt_Calcap_Weekly_Intake_Update>>> RetrieveAsync(DateTime? a_begin_dt, DateTime? a_end_dt)
		{
			try
			{
				var result = await _irpt_calcap_weekly_intake_updateservice.RetrieveAsync(a_begin_dt, a_end_dt, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
