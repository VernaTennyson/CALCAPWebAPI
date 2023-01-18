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
	public class Dw_Lea_Loan_App_LoanController : ControllerBase
	{
		private readonly IDw_Lea_Loan_App_LoanService _idw_lea_loan_app_loanservice;

		public Dw_Lea_Loan_App_LoanController(IDw_Lea_Loan_App_LoanService idw_lea_loan_app_loanservice)
		{
			_idw_lea_loan_app_loanservice = idw_lea_loan_app_loanservice;
		}

		//POST api/Dw_Lea_Loan_App_Loan/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dw_Lea_Loan_App_Loan> dataStore)
		{
			try
			{
				var result = await _idw_lea_loan_app_loanservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dw_Lea_Loan_App_Loan/Retrieve/{a_f_lenderId}
		[HttpGet("{a_f_lenderId}")]
		[ProducesResponseType(typeof(IDataStore<Dw_Lea_Loan_App_Loan>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dw_Lea_Loan_App_Loan>>> RetrieveAsync(decimal? a_f_lenderId)
		{
			try
			{
				var result = await _idw_lea_loan_app_loanservice.RetrieveAsync(a_f_lenderId, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
