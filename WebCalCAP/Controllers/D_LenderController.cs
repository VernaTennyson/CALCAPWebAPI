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
	public class D_LenderController : ControllerBase
	{
		private readonly ID_LenderService _id_lenderservice;

		public D_LenderController(ID_LenderService id_lenderservice)
		{
			_id_lenderservice = id_lenderservice;
		}

		//POST api/D_Lender/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Lender> dataStore)
		{
			try
			{
				var result = await _id_lenderservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Lender/Retrieve/{a_len_id}
		[HttpGet("{a_len_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Lender>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Lender>>> RetrieveAsync(double? a_len_id)
		{
			try
			{
				var result = await _id_lenderservice.RetrieveAsync(a_len_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
