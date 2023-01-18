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
	public class D_Abs_Lender_PickController : ControllerBase
	{
		private readonly ID_Abs_Lender_PickService _id_abs_lender_pickservice;

		public D_Abs_Lender_PickController(ID_Abs_Lender_PickService id_abs_lender_pickservice)
		{
			_id_abs_lender_pickservice = id_abs_lender_pickservice;
		}

		//POST api/D_Abs_Lender_Pick/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Lender_Pick> dataStore)
		{
			try
			{
				var result = await _id_abs_lender_pickservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Lender_Pick/Retrieve/{a_len}
		[HttpGet("{a_len}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Lender_Pick>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Lender_Pick>>> RetrieveAsync(string a_len)
		{
			try
			{
				var result = await _id_abs_lender_pickservice.RetrieveAsync(a_len, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
