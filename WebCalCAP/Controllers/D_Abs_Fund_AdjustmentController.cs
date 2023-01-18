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
	public class D_Abs_Fund_AdjustmentController : ControllerBase
	{
		private readonly ID_Abs_Fund_AdjustmentService _id_abs_fund_adjustmentservice;

		public D_Abs_Fund_AdjustmentController(ID_Abs_Fund_AdjustmentService id_abs_fund_adjustmentservice)
		{
			_id_abs_fund_adjustmentservice = id_abs_fund_adjustmentservice;
		}

		//POST api/D_Abs_Fund_Adjustment/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Fund_Adjustment> dataStore)
		{
			try
			{
				var result = await _id_abs_fund_adjustmentservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Fund_Adjustment/Retrieve/{p_loa_id}
		[HttpGet("{p_loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Fund_Adjustment>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Fund_Adjustment>>> RetrieveAsync(double? p_loa_id)
		{
			try
			{
				var result = await _id_abs_fund_adjustmentservice.RetrieveAsync(p_loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
