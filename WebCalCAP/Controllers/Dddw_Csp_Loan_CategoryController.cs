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
	public class Dddw_Csp_Loan_CategoryController : ControllerBase
	{
		private readonly IDddw_Csp_Loan_CategoryService _idddw_csp_loan_categoryservice;

		public Dddw_Csp_Loan_CategoryController(IDddw_Csp_Loan_CategoryService idddw_csp_loan_categoryservice)
		{
			_idddw_csp_loan_categoryservice = idddw_csp_loan_categoryservice;
		}

		//GET api/Dddw_Csp_Loan_Category/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Csp_Loan_Category>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Csp_Loan_Category>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_csp_loan_categoryservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
