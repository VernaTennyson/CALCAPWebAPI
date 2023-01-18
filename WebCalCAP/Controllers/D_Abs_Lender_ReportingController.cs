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
	public class D_Abs_Lender_ReportingController : ControllerBase
	{
		private readonly ID_Abs_Lender_ReportingService _id_abs_lender_reportingservice;

		public D_Abs_Lender_ReportingController(ID_Abs_Lender_ReportingService id_abs_lender_reportingservice)
		{
			_id_abs_lender_reportingservice = id_abs_lender_reportingservice;
		}

		//POST api/D_Abs_Lender_Reporting/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Lender_Reporting> dataStore)
		{
			try
			{
				var result = await _id_abs_lender_reportingservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Lender_Reporting/Retrieve/{a_len_id}
		[HttpGet("{a_len_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Lender_Reporting>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Lender_Reporting>>> RetrieveAsync(double? a_len_id)
		{
			try
			{
				var result = await _id_abs_lender_reportingservice.RetrieveAsync(a_len_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
