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
	public class Rpt_Loans_By_Borrower_MultiController : ControllerBase
	{
		private readonly IRpt_Loans_By_Borrower_MultiService _irpt_loans_by_borrower_multiservice;

		public Rpt_Loans_By_Borrower_MultiController(IRpt_Loans_By_Borrower_MultiService irpt_loans_by_borrower_multiservice)
		{
			_irpt_loans_by_borrower_multiservice = irpt_loans_by_borrower_multiservice;
		}

		//GET api/Rpt_Loans_By_Borrower_Multi/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Rpt_Loans_By_Borrower_Multi>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Rpt_Loans_By_Borrower_Multi>>> RetrieveAsync(String[] a_bor_name, String[] a_bor_dba)
		{
			try
			{
				var result = await _irpt_loans_by_borrower_multiservice.RetrieveAsync(a_bor_name, a_bor_dba, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
