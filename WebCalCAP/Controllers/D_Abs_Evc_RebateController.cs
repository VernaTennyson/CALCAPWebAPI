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
	public class D_Abs_Evc_RebateController : ControllerBase
	{
		private readonly ID_Abs_Evc_RebateService _id_abs_evc_rebateservice;

		public D_Abs_Evc_RebateController(ID_Abs_Evc_RebateService id_abs_evc_rebateservice)
		{
			_id_abs_evc_rebateservice = id_abs_evc_rebateservice;
		}

		//POST api/D_Abs_Evc_Rebate/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Evc_Rebate> dataStore)
		{
			try
			{
				var result = await _id_abs_evc_rebateservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Evc_Rebate/Retrieve/{a_evc}
		[HttpGet("{a_evc}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Evc_Rebate>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Evc_Rebate>>> RetrieveAsync(double? a_evc)
		{
			try
			{
				var result = await _id_abs_evc_rebateservice.RetrieveAsync(a_evc, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
