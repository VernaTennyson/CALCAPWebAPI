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
	public class Dddw_LenderController : ControllerBase
	{
		private readonly IDddw_LenderService _idddw_lenderservice;

		public Dddw_LenderController(IDddw_LenderService idddw_lenderservice)
		{
			_idddw_lenderservice = idddw_lenderservice;
		}

		//POST api/Dddw_Lender/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dddw_Lender> dataStore)
		{
			try
			{
				var result = await _idddw_lenderservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dddw_Lender/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Lender>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Lender>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_lenderservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
