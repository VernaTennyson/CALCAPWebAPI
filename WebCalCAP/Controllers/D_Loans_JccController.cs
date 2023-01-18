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
	public class D_Loans_JccController : ControllerBase
	{
		private readonly ID_Loans_JccService _id_loans_jccservice;

		public D_Loans_JccController(ID_Loans_JccService id_loans_jccservice)
		{
			_id_loans_jccservice = id_loans_jccservice;
		}

		//POST api/D_Loans_Jcc/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Loans_Jcc> dataStore)
		{
			try
			{
				var result = await _id_loans_jccservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Loans_Jcc/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Loans_Jcc>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Loans_Jcc>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_loans_jccservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
