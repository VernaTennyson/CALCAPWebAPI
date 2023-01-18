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
	public class D_Abs_Calcap_Purpose_LoanController : ControllerBase
	{
		private readonly ID_Abs_Calcap_Purpose_LoanService _id_abs_calcap_purpose_loanservice;

		public D_Abs_Calcap_Purpose_LoanController(ID_Abs_Calcap_Purpose_LoanService id_abs_calcap_purpose_loanservice)
		{
			_id_abs_calcap_purpose_loanservice = id_abs_calcap_purpose_loanservice;
		}

		//GET api/D_Abs_Calcap_Purpose_Loan/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Calcap_Purpose_Loan>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Calcap_Purpose_Loan>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_calcap_purpose_loanservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
