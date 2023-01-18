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
	public class Dddw_BorrowerController : ControllerBase
	{
		private readonly IDddw_BorrowerService _idddw_borrowerservice;

		public Dddw_BorrowerController(IDddw_BorrowerService idddw_borrowerservice)
		{
			_idddw_borrowerservice = idddw_borrowerservice;
		}

		//POST api/Dddw_Borrower/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dddw_Borrower> dataStore)
		{
			try
			{
				var result = await _idddw_borrowerservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dddw_Borrower/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Borrower>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Borrower>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_borrowerservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
