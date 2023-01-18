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
	public class Rpt_Loans_By_BorrowerController : ControllerBase
	{
		private readonly IRpt_Loans_By_BorrowerService _irpt_loans_by_borrowerservice;

		public Rpt_Loans_By_BorrowerController(IRpt_Loans_By_BorrowerService irpt_loans_by_borrowerservice)
		{
			_irpt_loans_by_borrowerservice = irpt_loans_by_borrowerservice;
		}

		//GET api/Rpt_Loans_By_Borrower/Retrieve/{a_bor_name}/{a_bor_dba}
		[HttpGet("{a_bor_name}/{a_bor_dba}")]
		[ProducesResponseType(typeof(IDataStore<Rpt_Loans_By_Borrower>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Rpt_Loans_By_Borrower>>> RetrieveAsync(string a_bor_name, string a_bor_dba)
		{
			try
			{
				var result = await _irpt_loans_by_borrowerservice.RetrieveAsync(a_bor_name, a_bor_dba, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
