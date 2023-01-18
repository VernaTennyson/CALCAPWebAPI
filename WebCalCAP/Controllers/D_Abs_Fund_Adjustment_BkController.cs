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
	public class D_Abs_Fund_Adjustment_BkController : ControllerBase
	{
		private readonly ID_Abs_Fund_Adjustment_BkService _id_abs_fund_adjustment_bkservice;

		public D_Abs_Fund_Adjustment_BkController(ID_Abs_Fund_Adjustment_BkService id_abs_fund_adjustment_bkservice)
		{
			_id_abs_fund_adjustment_bkservice = id_abs_fund_adjustment_bkservice;
		}

		//POST api/D_Abs_Fund_Adjustment_Bk/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Fund_Adjustment_Bk> dataStore)
		{
			try
			{
				var result = await _id_abs_fund_adjustment_bkservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Fund_Adjustment_Bk/Retrieve/{p_loa_id}
		[HttpGet("{p_loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Fund_Adjustment_Bk>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Fund_Adjustment_Bk>>> RetrieveAsync(double? p_loa_id)
		{
			try
			{
				var result = await _id_abs_fund_adjustment_bkservice.RetrieveAsync(p_loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
