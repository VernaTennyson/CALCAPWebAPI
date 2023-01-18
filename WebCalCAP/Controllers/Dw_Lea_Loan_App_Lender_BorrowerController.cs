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
	public class Dw_Lea_Loan_App_Lender_BorrowerController : ControllerBase
	{
		private readonly IDw_Lea_Loan_App_Lender_BorrowerService _idw_lea_loan_app_lender_borrowerservice;

		public Dw_Lea_Loan_App_Lender_BorrowerController(IDw_Lea_Loan_App_Lender_BorrowerService idw_lea_loan_app_lender_borrowerservice)
		{
			_idw_lea_loan_app_lender_borrowerservice = idw_lea_loan_app_lender_borrowerservice;
		}

		//POST api/Dw_Lea_Loan_App_Lender_Borrower/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dw_Lea_Loan_App_Lender_Borrower> dataStore)
		{
			try
			{
				var result = await _idw_lea_loan_app_lender_borrowerservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dw_Lea_Loan_App_Lender_Borrower/Retrieve/{a_f_lenderid}
		[HttpGet("{a_f_lenderid}")]
		[ProducesResponseType(typeof(IDataStore<Dw_Lea_Loan_App_Lender_Borrower>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dw_Lea_Loan_App_Lender_Borrower>>> RetrieveAsync(double? a_f_lenderid)
		{
			try
			{
				var result = await _idw_lea_loan_app_lender_borrowerservice.RetrieveAsync(a_f_lenderid, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
