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
	public class D_Arb_Rpt_OrigController : ControllerBase
	{
		private readonly ID_Arb_Rpt_OrigService _id_arb_rpt_origservice;

		public D_Arb_Rpt_OrigController(ID_Arb_Rpt_OrigService id_arb_rpt_origservice)
		{
			_id_arb_rpt_origservice = id_arb_rpt_origservice;
		}

		//GET api/D_Arb_Rpt_Orig/Retrieve/{a_arb_id}
		[HttpGet("{a_arb_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Arb_Rpt_Orig>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Arb_Rpt_Orig>>> RetrieveAsync(double? a_arb_id)
		{
			try
			{
				var result = await _id_arb_rpt_origservice.RetrieveAsync(a_arb_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
