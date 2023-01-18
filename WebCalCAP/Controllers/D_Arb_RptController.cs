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
	public class D_Arb_RptController : ControllerBase
	{
		private readonly ID_Arb_RptService _id_arb_rptservice;

		public D_Arb_RptController(ID_Arb_RptService id_arb_rptservice)
		{
			_id_arb_rptservice = id_arb_rptservice;
		}

		//GET api/D_Arb_Rpt/Retrieve/{a_arb_id}
		[HttpGet("{a_arb_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Arb_Rpt>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Arb_Rpt>>> RetrieveAsync(double? a_arb_id)
		{
			try
			{
				var result = await _id_arb_rptservice.RetrieveAsync(a_arb_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
