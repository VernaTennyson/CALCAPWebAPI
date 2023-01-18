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
	public class Dddw_LoanController : ControllerBase
	{
		private readonly IDddw_LoanService _idddw_loanservice;

		public Dddw_LoanController(IDddw_LoanService idddw_loanservice)
		{
			_idddw_loanservice = idddw_loanservice;
		}

		//POST api/Dddw_Loan/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dddw_Loan> dataStore)
		{
			try
			{
				var result = await _idddw_loanservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dddw_Loan/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Loan>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Loan>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_loanservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
