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
	public class D_Abs_Comp_RptController : ControllerBase
	{
		private readonly ID_Abs_Comp_RptService _id_abs_comp_rptservice;

		public D_Abs_Comp_RptController(ID_Abs_Comp_RptService id_abs_comp_rptservice)
		{
			_id_abs_comp_rptservice = id_abs_comp_rptservice;
		}

		//GET api/D_Abs_Comp_Rpt/Retrieve/{a_date}
		[HttpGet("{a_date}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Comp_Rpt>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Comp_Rpt>>> RetrieveAsync(DateTime? a_date)
		{
			try
			{
				var result = await _id_abs_comp_rptservice.RetrieveAsync(a_date, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
