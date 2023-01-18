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
	public class D_Loans_TestController : ControllerBase
	{
		private readonly ID_Loans_TestService _id_loans_testservice;

		public D_Loans_TestController(ID_Loans_TestService id_loans_testservice)
		{
			_id_loans_testservice = id_loans_testservice;
		}

		//POST api/D_Loans_Test/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Loans_Test> dataStore)
		{
			try
			{
				var result = await _id_loans_testservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Loans_Test/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Loans_Test>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Loans_Test>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_loans_testservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
