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
	public class D_Loan_FundingController : ControllerBase
	{
		private readonly ID_Loan_FundingService _id_loan_fundingservice;

		public D_Loan_FundingController(ID_Loan_FundingService id_loan_fundingservice)
		{
			_id_loan_fundingservice = id_loan_fundingservice;
		}

		//POST api/D_Loan_Funding/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Loan_Funding> dataStore)
		{
			try
			{
				var result = await _id_loan_fundingservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Loan_Funding/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Loan_Funding>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Loan_Funding>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_loan_fundingservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
